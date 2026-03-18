import json
import socket
from kafka import KafkaConsumer

consumer = KafkaConsumer(
    "test-device-data",
    bootstrap_servers="localhost:29092",
    group_id="reporting-group",  # 👈 önemli
    auto_offset_reset="earliest",
    enable_auto_commit=True,
    value_deserializer=lambda v: json.loads(v.decode()),
    key_deserializer=lambda k: k.decode() if k else None
)

consumer_name = socket.gethostname()  # kim çalışıyor görelim

print(f"Consumer başladı: {consumer_name}")

for msg in consumer:
    print(f"""
[{consumer_name}]
Partition: {msg.partition}
Key: {msg.key}
Value: {msg.value}
""")