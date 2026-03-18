# producer.py

import json
import random
import time
import uuid
from kafka import KafkaProducer

producer = KafkaProducer(
    bootstrap_servers="localhost:29092",

    # serialization
    value_serializer=lambda v: json.dumps(v).encode(),
    key_serializer=lambda k: k.encode(),

    # 🔥 performans ayarları (opsiyonel ama önerilir)
    linger_ms=5,
    batch_size=16384
)

devices = [f"Device-{i}" for i in range(1, 11)]

print("Producer başladı...")

while True:
    device = random.choice(devices)

    data = {
        "eventId": str(uuid.uuid4()),   # 🔥 unique id (çok önemli)
        "deviceId": device,
        "value": random.randint(0, 100),
        "timestamp": time.time(),

        # 🔥 retry sistemi için
        "retryCount": 0
    }

    producer.send(
        "device-data",
        key=device,   # 🔥 aynı device aynı partition'a gider
        value=data
    )

    print(f"[PRODUCER] {data}")

    time.sleep(0.5)