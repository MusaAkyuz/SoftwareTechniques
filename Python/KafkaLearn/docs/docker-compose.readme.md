version: "3.8" -> Docker Compose dosya formatının versiyonu.

services:
kafka:
image: bitnami/kafka:latest
container_name: kafka
ports: - "9092:9092"
environment: - KAFKA_ENABLE_KRAFT=yes -> Kafka’yı Zookeeper’sız modda çalıştır. - KAFKA_CFG_NODE_ID=1 -> Bu Kafka node’unun kimliği. cluster olsaydı her birinin farklı idsi olurdu - KAFKA_CFG_PROCESS_ROLES=broker,controller -> broker mesaj tutar, controller cluster yönetir - KAFKA_CFG_CONTROLLER_QUORUM_VOTERS=1@kafka:9093 - KAFKA_CFG_LISTENERS=PLAINTEXT://:9092,CONTROLLER://:9093 - KAFKA_CFG_ADVERTISED_LISTENERS=PLAINTEXT://localhost:9092 - KAFKA_CFG_CONTROLLER_LISTENER_NAMES=CONTROLLER - ALLOW_PLAINTEXT_LISTENER=yes
