# alarm_service.py
import json
from kafka import KafkaConsumer, KafkaProducer

consumer = KafkaConsumer(
    "device-data",
    bootstrap_servers="localhost:29092",
    group_id="alarm-group",
    value_deserializer=lambda v: json.loads(v.decode()),
    key_deserializer=lambda k: k.decode() if k else None
)

producer = KafkaProducer(
    bootstrap_servers="localhost:29092",
    value_serializer=lambda v: json.dumps(v).encode()
)

print("Alarm service başladı...")

for msg in consumer:
    data = msg.value

    if data["value"] > 80:
        alarm = {
            "deviceId": data["deviceId"],
            "value": data["value"],
            "message": "HIGH VALUE ALERT!"
        }

        producer.send("alarm-events", value=alarm)

        print(f"[ALARM] {alarm}")