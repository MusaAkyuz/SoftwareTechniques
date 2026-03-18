# dlq_consumer.py

import json
from kafka import KafkaConsumer

consumer = KafkaConsumer(
    "device-data-dlq",
    bootstrap_servers="localhost:29092",
    group_id="dlq-group",
    value_deserializer=lambda v: json.loads(v.decode())
)

print("DLQ consumer başladı...")

for msg in consumer:
    print(f"💀 DLQ EVENT: {msg.value}")