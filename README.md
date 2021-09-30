# Test.It.With.AMQP.091.Protocol
Contains protocol definitions for AMQP 0.9.1 which can be used by [Test.It.With.AMQP] testing framework.

[![Continuous Delivery](https://github.com/Fresa/Test.It.With.AMQP.091.Protocol/actions/workflows/ci.yml/badge.svg)](https://github.com/Fresa/Test.It.With.AMQP.091.Protocol/actions/workflows/ci.yml)

## Download
https://www.nuget.org/packages/Test.It.With.Amqp.091.Protocol/

## Getting Started
See [Test.It.With.RabbitMQ.091] for a protocol implementation and integration with the c# [RabbitMQ client][RabbitMQ].

### Protocol Definitions
You can find the complete protocol definition for AMQP 0.9.1 in [Amqp091Protocol.cs][ProtocolDefinitionSourceFile].

### Protocol Resolver
[Amqp091.cs][ProtocolResolverSourceFile] contains the entry point for integration with the [Test.It.With.AMQP] testing framework.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://github.com/Fresa/Port/blob/master/LICENSE)

[Test.It.With.AMQP]: <https://github.com/Fresa/Test.It.With.AMQP>
[Test.It.With.RabbitMQ.091]:
<https://github.com/Fresa/Test.It.With.RabbitMQ.091>
[RabbitMQ]:
<https://github.com/rabbitmq/rabbitmq-dotnet-client>
[ProtocolDefinitionSourceFile]:
<https://github.com/Fresa/Test.It.With.AMQP.091.Protocol/blob/master/Test.It.With.Amqp.091.Protocol/Amqp091Protocol.cs>
[ProtocolResolverSourceFile]:
<https://github.com/Fresa/Test.It.With.AMQP.091.Protocol/blob/master/Test.It.With.Amqp.091.Protocol/Amqp091.cs>
