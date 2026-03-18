# consumer_manual_commit.py

import json
import time
from kafka import KafkaConsumer

consumer = KafkaConsumer(
    "device-data",
    bootstrap_servers="localhost:29092",
    group_id="manual-commit-group",

    enable_auto_commit=False,  # ❗ EN KRİTİK AYAR

    value_deserializer=lambda v: json.loads(v.decode()),
    key_deserializer=lambda k: k.decode() if k else None
)

print("Consumer başladı...")

def process(data):
    """
    Senin iş mantığın burada
    """
    print(f"[PROCESSING] {data}")

    # simüle hata
    if data["value"] > 95:
        raise Exception("Simüle hata!")

    time.sleep(0.2)


for msg in consumer:
    try:
        process(msg.value)

        # ✅ SADECE BAŞARILIYSA COMMIT
        consumer.commit()

        print(f"[COMMIT] offset işlendi")

    except Exception as e:
        print(f"[ERROR] {e}")

        # ❌ commit yok → Kafka tekrar gönderir