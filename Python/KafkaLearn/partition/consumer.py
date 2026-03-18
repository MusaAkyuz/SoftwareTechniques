import json
from kafka import KafkaConsumer

consumer = KafkaConsumer(
    "test-device-data",
    bootstrap_servers='localhost:9092',
    group_id='reporting-service',
    auto_offset_reset='earliest',
    enable_auto_commit=True,
    value_deserializer=lambda v: json.loads(v.decode('utf-8')),
    key_deserializer=lambda k: k.decode('utf-8') if k else None
)

print("Consumer started...")

for message in consumer:
    print("------")
    print("Partition:", message.partition)
    print("Key:", message.key)
    print("Value:", message.value)