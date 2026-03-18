import json
import random
import time
from kafka import KafkaProducer

# Kafka Producer
producer = KafkaProducer(
    bootstrap_servers='localhost:9092',
    value_serializer=lambda v: json.dumps(v).encode('utf-8'),
    key_serializer=lambda k: k.encode('utf-8')
)

# 10 device key
device_keys = [f"Device-{i}" for i in range(1, 11)]

while True:
    key = random.choice(device_keys)
    value = {
        "deviceId": key,
        "value": random.randint(0, 100),
        "timestamp": time.time()
    }

    producer.send("test-device-data", key=key, value=value)

    print(f"Sent → {value}")

    time.sleep(1)