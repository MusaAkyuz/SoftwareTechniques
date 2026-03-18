# dashboard.py
import json
from kafka import KafkaConsumer

consumer = KafkaConsumer(
    "device-data",
    "alarm-events",
    bootstrap_servers="localhost:29092",
    group_id="dashboard-group",
    value_deserializer=lambda v: json.loads(v.decode()),
    key_deserializer=lambda k: k.decode() if k else None
)

print("Dashboard başladı...")

for msg in consumer:
    if msg.topic == "device-data":
        print(f"[DATA] {msg.value}")

    elif msg.topic == "alarm-events":
        print(f"🚨 [ALARM] {msg.value}")