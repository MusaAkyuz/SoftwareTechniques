# consumer_with_retry.py

import json
import time
from kafka import KafkaConsumer, KafkaProducer

MAX_RETRY = 3

consumer = KafkaConsumer(
    "device-data",
    "device-data-retry",
    bootstrap_servers="localhost:29092",
    group_id="retry-group",
    enable_auto_commit=False,
    value_deserializer=lambda v: json.loads(v.decode())
)

producer = KafkaProducer(
    bootstrap_servers="localhost:29092",
    value_serializer=lambda v: json.dumps(v).encode()
)

print("Consumer with retry başladı...")


def process(data):
    print(f"[PROCESS] {data}")

    # 🔥 simüle hata
    if data["value"] > 80:
        raise Exception("Simulated error")

    time.sleep(0.2)


for msg in consumer:
    data = msg.value

    try:
        process(data)

        consumer.commit()
        print("✅ SUCCESS")

    except Exception as e:
        print(f"❌ ERROR: {e}")

        retry_count = data.get("retryCount", 0)

        if retry_count < MAX_RETRY:
            data["retryCount"] = retry_count + 1

            producer.send("device-data-retry", value=data)

            print(f"🔁 RETRY gönderildi ({data['retryCount']})")

        else:
            producer.send("device-data-dlq", value=data)

            print("💀 DLQ'ya gönderildi")

        consumer.commit()  # ⚠️ önemli!