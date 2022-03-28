// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/jogadores.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcClient {
  public static partial class Jogador
  {
    static readonly string __ServiceName = "Jogador";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcClient.JogadorIdentidade> __Marshaller_JogadorIdentidade = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.JogadorIdentidade.Parser));
    static readonly grpc::Marshaller<global::GrpcClient.JogadorMensagem> __Marshaller_JogadorMensagem = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.JogadorMensagem.Parser));
    static readonly grpc::Marshaller<global::GrpcClient.JogadorAposta> __Marshaller_JogadorAposta = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.JogadorAposta.Parser));
    static readonly grpc::Marshaller<global::GrpcClient.JogadorResultadoAposta> __Marshaller_JogadorResultadoAposta = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.JogadorResultadoAposta.Parser));
    static readonly grpc::Marshaller<global::GrpcClient.JogadorDados> __Marshaller_JogadorDados = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.JogadorDados.Parser));
    static readonly grpc::Marshaller<global::GrpcClient.JogadorChavesAnteriores> __Marshaller_JogadorChavesAnteriores = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.JogadorChavesAnteriores.Parser));

    static readonly grpc::Method<global::GrpcClient.JogadorIdentidade, global::GrpcClient.JogadorMensagem> __Method_VerificaEntrada = new grpc::Method<global::GrpcClient.JogadorIdentidade, global::GrpcClient.JogadorMensagem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VerificaEntrada",
        __Marshaller_JogadorIdentidade,
        __Marshaller_JogadorMensagem);

    static readonly grpc::Method<global::GrpcClient.JogadorAposta, global::GrpcClient.JogadorResultadoAposta> __Method_RecebeApostaChave = new grpc::Method<global::GrpcClient.JogadorAposta, global::GrpcClient.JogadorResultadoAposta>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RecebeApostaChave",
        __Marshaller_JogadorAposta,
        __Marshaller_JogadorResultadoAposta);

    static readonly grpc::Method<global::GrpcClient.JogadorDados, global::GrpcClient.JogadorChavesAnteriores> __Method_VerApostas = new grpc::Method<global::GrpcClient.JogadorDados, global::GrpcClient.JogadorChavesAnteriores>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "VerApostas",
        __Marshaller_JogadorDados,
        __Marshaller_JogadorChavesAnteriores);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcClient.JogadoresReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Jogador</summary>
    public partial class JogadorClient : grpc::ClientBase<JogadorClient>
    {
      /// <summary>Creates a new client for Jogador</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public JogadorClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Jogador that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public JogadorClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected JogadorClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected JogadorClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcClient.JogadorMensagem VerificaEntrada(global::GrpcClient.JogadorIdentidade request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VerificaEntrada(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcClient.JogadorMensagem VerificaEntrada(global::GrpcClient.JogadorIdentidade request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VerificaEntrada, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.JogadorMensagem> VerificaEntradaAsync(global::GrpcClient.JogadorIdentidade request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VerificaEntradaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.JogadorMensagem> VerificaEntradaAsync(global::GrpcClient.JogadorIdentidade request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VerificaEntrada, null, options, request);
      }
      public virtual global::GrpcClient.JogadorResultadoAposta RecebeApostaChave(global::GrpcClient.JogadorAposta request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RecebeApostaChave(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcClient.JogadorResultadoAposta RecebeApostaChave(global::GrpcClient.JogadorAposta request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RecebeApostaChave, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.JogadorResultadoAposta> RecebeApostaChaveAsync(global::GrpcClient.JogadorAposta request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RecebeApostaChaveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.JogadorResultadoAposta> RecebeApostaChaveAsync(global::GrpcClient.JogadorAposta request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RecebeApostaChave, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcClient.JogadorChavesAnteriores> VerApostas(global::GrpcClient.JogadorDados request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VerApostas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcClient.JogadorChavesAnteriores> VerApostas(global::GrpcClient.JogadorDados request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_VerApostas, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override JogadorClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new JogadorClient(configuration);
      }
    }

  }
}
#endregion
