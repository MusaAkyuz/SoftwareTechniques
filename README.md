# SoftwareTechniques

A personal collection of small, focused exercises for learning and practicing software engineering techniques — C# language features and design patterns, Python event-driven/Kafka messaging, and LeetCode problem solutions. Each subfolder is a self-contained, runnable example rather than parts of a single application.

## Contents

### C#

| Folder | Topic |
|---|---|
| `Abstract-Virtual-Override` | `abstract`, `virtual`, and `override` keyword usage |
| `AdminRightsSetupDemo` | Requesting UAC elevation (admin rights) from a Windows app, plus a Visual Studio Installer setup project |
| `Cache` | In-memory caching with `System.Runtime.Caching.MemoryCache` |
| `DataAnnotation` | Conditional validation with data annotations |
| `Delegates-Events` | Delegates and the observer/event pattern (two variations) |
| `DependencyInjection` | Constructor injection vs. setter injection |
| `EntityFrameworkDB` | EF Core: code-first migrations and database-first scaffolding |
| `FactoryPattern` | Factory pattern via abstract classes vs. via interfaces |
| `Interfaces` | Interface basics, generic interfaces, and picking a `DbContext` through a generic interface |
| `LeetCodeExercise` | Standalone LeetCode problem solutions (e.g. Palindrome Number, Middle of the Linked List) |

Each C# example is its own Visual Studio solution (`.sln` + `.csproj`) and can be opened/built independently.

### Python

| Folder | Topic |
|---|---|
| `EventDriven` | A minimal event-driven pipeline over Kafka: producer → alarm service (consumer+producer) → dashboard (consumer) |
| `KafkaLearn` | Kafka fundamentals in isolated examples: basic producer/consumer, partitioning, consumer groups, offset strategies, and retry/DLQ (dead-letter queue) handling. Includes a `docker-compose.yml` to run a local single-node Kafka broker (KRaft mode, no Zookeeper) |

## Requirements

- **C# examples:** .NET 6/8 SDK, Visual Studio or `dotnet` CLI (per-project target framework varies — check each `.csproj`).
- **Python examples:** Python 3.10+, `pip install confluent-kafka` (or the Kafka client used in the script) for the Kafka-based ones.
- **Kafka examples:** Docker, to run `Python/KafkaLearn/docker-compose.yml`.

## Running an example

C# projects:

```bash
cd "C#/FactoryPattern/AbstractFactoryPattern/AbstractFactoryPattern"
dotnet run
```

Python/Kafka projects (start the broker first):

```bash
cd Python/KafkaLearn
docker compose up -d
cd simple
python producer.py
python consumer.py
```

## Notes

- Build output (`bin/`, `obj/`, `.vs/`) is not tracked — each project builds cleanly from source.
- Some subfolders have their own `readme.md` with example-specific notes (e.g. `Python/EventDriven`, `Python/KafkaLearn/consumer-group`, `Python/KafkaLearn/docs`).

## License

This project is licensed under the [MIT License](LICENSE).
