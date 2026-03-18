from kafka import KafkaProducer
import json

# Kafka'ya bağlan
producer = KafkaProducer(
    bootstrap_servers='localhost:9092',
    value_serializer=lambda v: json.dumps(v).encode('utf-8')
)

# Topic'e mesaj gönder
producer.send('test-topic', {
    "message": "Merhaba Kafka",
    "status": "ok"
})

producer.flush()
print("Mesaj gönderildi 🚀")