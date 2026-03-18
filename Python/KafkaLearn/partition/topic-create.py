from kafka.admin import KafkaAdminClient, NewTopic
from kafka.errors import TopicAlreadyExistsError

# Admin client
admin_client = KafkaAdminClient(
    bootstrap_servers="localhost:29092",
    client_id="topic-creator"
)

# Topic tanımı
topic_name = "test-device-data"

topic = NewTopic(
    name=topic_name,
    num_partitions=10,      # 👈 10 partition
    replication_factor=1    # Single broker için 1
)

try:
    admin_client.create_topics(new_topics=[topic])
    print(f"Topic '{topic_name}' created successfully.")
except TopicAlreadyExistsError:
    print(f"Topic '{topic_name}' already exists.")

admin_client.close()