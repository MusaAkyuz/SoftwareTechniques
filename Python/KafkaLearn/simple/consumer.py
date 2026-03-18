from kafka import KafkaConsumer
import json

# Kafka'ya bağlan
consumer = KafkaConsumer(
    'test-topic',
    bootstrap_servers='localhost:9092',
    auto_offset_reset='earliest',  # Baştan oku
    enable_auto_commit=True,
    group_id='my-group',
    value_deserializer=lambda x: json.loads(x.decode('utf-8'))
)

print("Mesajlar bekleniyor...")

for message in consumer:
    print("Gelen mesaj:", message.value)