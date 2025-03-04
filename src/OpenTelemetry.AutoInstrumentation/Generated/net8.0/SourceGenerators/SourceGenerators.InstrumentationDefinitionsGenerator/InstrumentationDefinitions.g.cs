﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the InstrumentationDefinitionsGenerator tool. To safely
//     modify this file, edit InstrumentMethodAttribute on the classes and
//     compile project.

//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. 
// </auto-generated>
//------------------------------------------------------------------------------

using OpenTelemetry.AutoInstrumentation.Configurations;

namespace OpenTelemetry.AutoInstrumentation;

internal static partial class InstrumentationDefinitions
{
    private static NativeCallTargetDefinition[] GetDefinitionsArray()
    {
        var nativeCallTargetDefinitions = new List<NativeCallTargetDefinition>(39);
        // Traces
        var tracerSettings = Instrumentation.TracerSettings.Value;
        if (tracerSettings.TracesEnabled)
        {
            // Axal
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.Axal))
            {
                nativeCallTargetDefinitions.Add(new("?Examples", "?Examples.AspNetCoreMvc.Logic", "?", ["System.Void"], 1, 0, 0, 65535, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Axal.AxalIntegration"));
            }

            // Kafka
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.Kafka))
            {
                nativeCallTargetDefinitions.Add(new("Confluent.Kafka", "Confluent.Kafka.Consumer`2", "Close", ["System.Void"], 1, 4, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Kafka.Integrations.ConsumerCloseIntegration"));
                nativeCallTargetDefinitions.Add(new("Confluent.Kafka", "Confluent.Kafka.Consumer`2", ".ctor", ["System.Void", "Confluent.Kafka.ConsumerBuilder`2[!0,!1]"], 1, 4, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Kafka.Integrations.ConsumerConstructorIntegration"));
                nativeCallTargetDefinitions.Add(new("Confluent.Kafka", "Confluent.Kafka.Consumer`2", "Consume", ["Confluent.Kafka.ConsumeResult`2[!0,!1]", "System.Int32"], 1, 4, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Kafka.Integrations.ConsumerConsumeSyncIntegration"));
                nativeCallTargetDefinitions.Add(new("Confluent.Kafka", "Confluent.Kafka.Consumer`2", "Dispose", ["System.Void"], 1, 4, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Kafka.Integrations.ConsumerDisposeIntegration"));
                nativeCallTargetDefinitions.Add(new("Confluent.Kafka", "Confluent.Kafka.Producer`2+TypedDeliveryHandlerShim_Action", ".ctor", ["System.Void", "System.String", "!0", "!1", "System.Action`1[Confluent.Kafka.DeliveryReport`2[!0,!1]]"], 1, 4, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Kafka.Integrations.ProducerDeliveryHandlerActionIntegration"));
                nativeCallTargetDefinitions.Add(new("Confluent.Kafka", "Confluent.Kafka.Producer`2", "ProduceAsync", ["System.Threading.Tasks.Task`1[Confluent.Kafka.DeliveryReport`2[!0,!1]]", "Confluent.Kafka.TopicPartition", "Confluent.Kafka.Message`2[!0,!1]", "System.Threading.CancellationToken"], 1, 4, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Kafka.Integrations.ProducerProduceAsyncIntegration"));
                nativeCallTargetDefinitions.Add(new("Confluent.Kafka", "Confluent.Kafka.Producer`2", "Produce", ["System.Void", "Confluent.Kafka.TopicPartition", "Confluent.Kafka.Message`2[!0,!1]", "System.Action`1[Confluent.Kafka.DeliveryReport`2[!0,!1]]"], 1, 4, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Kafka.Integrations.ProducerProduceSyncIntegration"));
            }

            // MongoDB
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.MongoDB))
            {
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.Core.WireProtocol.CommandUsingQueryMessageWireProtocol`1", "Execute", ["!0", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 3, 0, 0, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecute"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.Core.WireProtocol.CommandUsingCommandMessageWireProtocol`1", "Execute", ["!0", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 3, 0, 0, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecute"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.Core.WireProtocol.QueryWireProtocol`1", "Execute", ["!0", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 3, 0, 0, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecute"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.Core.WireProtocol.WriteWireProtocolBase`1", "Execute", ["!0", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 3, 0, 0, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecute"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver.Core", "MongoDB.Driver.Core.WireProtocol.CommandUsingQueryMessageWireProtocol`1", "Execute", ["!0", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 2, 7, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecute"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver.Core", "MongoDB.Driver.Core.WireProtocol.CommandUsingCommandMessageWireProtocol`1", "Execute", ["!0", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 2, 7, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecute"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver.Core", "MongoDB.Driver.Core.WireProtocol.QueryWireProtocol`1", "Execute", ["!0", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 2, 7, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecute"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver.Core", "MongoDB.Driver.Core.WireProtocol.WriteWireProtocolBase`1", "Execute", ["!0", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 2, 7, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecute"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.Core.WireProtocol.CommandUsingQueryMessageWireProtocol`1", "ExecuteAsync", ["System.Threading.Tasks.Task`1[!0]", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 3, 0, 0, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecuteAsync"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.Core.WireProtocol.CommandUsingCommandMessageWireProtocol`1", "ExecuteAsync", ["System.Threading.Tasks.Task`1[!0]", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 3, 0, 0, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecuteAsync"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.Core.WireProtocol.QueryWireProtocol`1", "ExecuteAsync", ["System.Threading.Tasks.Task`1[!0]", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 3, 0, 0, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecuteAsync"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.Core.WireProtocol.WriteWireProtocolBase`1", "ExecuteAsync", ["System.Threading.Tasks.Task`1[!0]", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 3, 0, 0, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecuteAsync"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver.Core", "MongoDB.Driver.Core.WireProtocol.CommandUsingQueryMessageWireProtocol`1", "ExecuteAsync", ["System.Threading.Tasks.Task`1[!0]", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 2, 7, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecuteAsync"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver.Core", "MongoDB.Driver.Core.WireProtocol.CommandUsingCommandMessageWireProtocol`1", "ExecuteAsync", ["System.Threading.Tasks.Task`1[!0]", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 2, 7, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecuteAsync"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver.Core", "MongoDB.Driver.Core.WireProtocol.QueryWireProtocol`1", "ExecuteAsync", ["System.Threading.Tasks.Task`1[!0]", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 2, 7, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecuteAsync"));
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver.Core", "MongoDB.Driver.Core.WireProtocol.WriteWireProtocolBase`1", "ExecuteAsync", ["System.Threading.Tasks.Task`1[!0]", "MongoDB.Driver.Core.Connections.IConnection", "System.Threading.CancellationToken"], 2, 7, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.Integrations.MongoClientIntegrationExecuteAsync"));
            }

            // NServiceBus
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.NServiceBus))
            {
                nativeCallTargetDefinitions.Add(new("NServiceBus.Core", "NServiceBus.EndpointConfiguration", ".ctor", ["System.Void", "System.String"], 8, 0, 0, 9, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.NServiceBus.EndpointConfigurationIntegration"));
            }

            // RabbitMq
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.RabbitMq))
            {
                nativeCallTargetDefinitions.Add(new("RabbitMQ.Client", "RabbitMQ.Client.Impl.ModelBase", "BasicGet", ["RabbitMQ.Client.BasicGetResult", "System.String", "System.Boolean"], 6, 0, 0, 6, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.RabbitMq6.Integrations.ModelBaseBasicGetIntegration"));
                nativeCallTargetDefinitions.Add(new("RabbitMQ.Client", "RabbitMQ.Client.Framing.Impl.Model", "_Private_BasicPublish", ["System.Void", "System.String", "System.String", "System.Boolean", "RabbitMQ.Client.IBasicProperties", "System.ReadOnlyMemory`1[System.Byte]"], 6, 0, 0, 6, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.RabbitMq6.Integrations.ModelBasicPublishIntegration"));
            }

            // StackExchangeRedis
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.StackExchangeRedis))
            {
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImpl", ["StackExchange.Redis.ConnectionMultiplexer", "StackExchange.Redis.ConfigurationOptions", "System.IO.TextWriter", "System.Nullable`1[StackExchange.Redis.ServerType]", "StackExchange.Redis.EndPointCollection"], 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegration"));
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImplAsync", ["System.Threading.Tasks.Task`1[StackExchange.Redis.ConnectionMultiplexer]", "StackExchange.Redis.ConfigurationOptions", "System.IO.TextWriter", "System.Nullable`1[StackExchange.Redis.ServerType]"], 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegrationAsync"));
            }

            // WcfClient
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.WcfClient))
            {
                nativeCallTargetDefinitions.Add(new("System.Private.ServiceModel", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", ["System.Void", "System.String", "System.ServiceModel.EndpointAddress"], 4, 0, 0, 4, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.Private.ServiceModel", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", ["System.Void", "System.ServiceModel.Description.ServiceEndpoint"], 4, 0, 0, 4, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.Private.ServiceModel", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", ["System.Void", "System.ServiceModel.Channels.Binding", "System.ServiceModel.EndpointAddress"], 4, 0, 0, 4, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.ServiceModel.Primitives", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", ["System.Void", "System.String", "System.ServiceModel.EndpointAddress"], 6, 0, 0, 8, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.ServiceModel.Primitives", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", ["System.Void", "System.ServiceModel.Description.ServiceEndpoint"], 6, 0, 0, 8, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.ServiceModel.Primitives", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", ["System.Void", "System.ServiceModel.Channels.Binding", "System.ServiceModel.EndpointAddress"], 6, 0, 0, 8, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
            }
        }

        // Logs
        var logSettings = Instrumentation.LogSettings.Value;
        if (logSettings.LogsEnabled)
        {
            // Log4Net
            if (logSettings.EnabledInstrumentations.Contains(LogInstrumentation.Log4Net))
            {
                nativeCallTargetDefinitions.Add(new("log4net", "log4net.Appender.AppenderCollection", "ToArray", ["log4net.Appender.IAppender[]"], 2, 0, 13, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Log4Net.Bridge.Integrations.AppenderCollectionIntegration"));
                nativeCallTargetDefinitions.Add(new("log4net", "log4net.Util.AppenderAttachedImpl", "AppendLoopOnAppenders", ["System.Int32", "log4net.Core.LoggingEvent"], 2, 0, 13, 3, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Log4Net.TraceContextInjection.Integrations.AppenderAttachedImplIntegration"));
            }

            // ILogger
            if (logSettings.EnabledInstrumentations.Contains(LogInstrumentation.ILogger))
            {
                nativeCallTargetDefinitions.Add(new("Microsoft.Extensions.Logging", "Microsoft.Extensions.Logging.LoggingBuilder", ".ctor", ["System.Void", "Microsoft.Extensions.DependencyInjection.IServiceCollection"], 9, 0, 0, 9, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Logger.LoggingBuilderIntegration"));
            }
        }

        // Metrics
        var metricSettings = Instrumentation.MetricSettings.Value;
        if (metricSettings.MetricsEnabled)
        {
            // NServiceBus
            if (metricSettings.EnabledInstrumentations.Contains(MetricInstrumentation.NServiceBus))
            {
                nativeCallTargetDefinitions.Add(new("NServiceBus.Core", "NServiceBus.EndpointConfiguration", ".ctor", ["System.Void", "System.String"], 8, 0, 0, 9, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.NServiceBus.EndpointConfigurationIntegration"));
            }
        }

        return nativeCallTargetDefinitions.ToArray();
    }
}
