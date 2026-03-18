# producer.py

import json
import random
import time
from kafka import KafkaProducer

producer = KafkaProducer(
    bootstrap_servers="localhost:29092",
    value_serializer=lambda v: json.dumps(v).encode(),
    key_serializer=lambda k: k.encode(),

    # 🔥 performans ayarları (opsiyonel ama güzel)
    linger_ms=5,
    batch_size=16384
)

devices = [f"Device-{i}" for i in range(1, 11)]

while True:
    device = random.choice(devices)

    data = {
        "eventId": f"{device}-{int(time.time() * 1000)}",  # 🔥 idempotency için
        "deviceId": device,
        "value": random.randint(0, 100),
        "timestamp": time.time()
    }

    producer.send(
        "device-data",
        key=device,
        value=data
    )

    print(f"[PRODUCER] {data}")

    time.sleep(0.5)