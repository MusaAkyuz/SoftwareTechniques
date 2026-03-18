Device → Kafka → Alarm Service → Kafka → Dashboard

🟢 1. Producer (Cihazlar)
veri üretir
topic: device-data

🔴 2. Alarm Service (Consumer + Producer)
device-data’yı dinler
value > 80 → alarm üretir
topic: alarm-events

🔵 3. Dashboard (Consumer)
hem device-data hem alarm-events dinler
ekrana basar
