# create_topics.py

from kafka.admin import KafkaAdminClient, NewTopic
from kafka.errors import TopicAlreadyExistsError

BOOTSTRAP_SERVERS = "localhost:29092"

admin_client = KafkaAdminClient(
    bootstrap_servers=BOOTSTRAP_SERVERS,
    client_id="topic-creator"
)

topics = [
    NewTopic(
        name="device-data",
        num_partitions=10,
        replication_factor=1
    ),
    NewTopic(
        name="device-data-retry",
        num_partitions=5,
        replication_factor=1
    ),
    NewTopic(
        name="device-data-dlq",
        num_partitions=3,
        replication_factor=1
    )
]

try:
    admin_client.create_topics(new_topics=topics, validate_only=False)
    print("✅ Tüm topicler oluşturuldu")

except TopicAlreadyExistsError:
    print("⚠️ Bazı topicler zaten var")

except Exception as e:
    print(f"❌ Hata: {e}")

finally:
    admin_client.close()