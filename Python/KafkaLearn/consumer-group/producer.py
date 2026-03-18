import json
import random
import time
from kafka import KafkaProducer

producer = KafkaProducer(
    bootstrap_servers="localhost:29092",
    value_serializer=lambda v: json.dumps(v).encode(),
    key_serializer=lambda k: k.encode()
)

devices = [f"Device-{i}" for i in range(1, 11)]

while True:
    device = random.choice(devices)

    data = {
        "deviceId": device,
        "value": random.randint(0, 100),
        "timestamp": time.time()
    }

    producer.send("test-device-data", key=device, value=data)

    print(f"[PRODUCER] {device} gönderdi")

    time.sleep(0.2)