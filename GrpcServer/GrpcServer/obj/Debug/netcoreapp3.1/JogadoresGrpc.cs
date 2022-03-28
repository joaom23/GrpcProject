// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/jogadores.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class Jogador
  {
    static readonly string __ServiceName = "Jogador";

    static readonly grpc::Marshaller<global::GrpcServer.JogadorIdentidade> __Marshaller_JogadorIdentidade = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.JogadorIdentidade.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.JogadorMensagem> __Marshaller_JogadorMensagem = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.JogadorMensagem.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.JogadorAposta> __Marshaller_JogadorAposta = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.JogadorAposta.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.JogadorResultadoAposta> __Marshaller_JogadorResultadoAposta = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.JogadorResultadoAposta.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.JogadorDados> __Marshaller_JogadorDados = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.JogadorDados.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.JogadorChavesAnteriores> __Marshaller_JogadorChavesAnteriores = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.JogadorChavesAnteriores.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.JogadorIdentidade, global::GrpcServer.JogadorMensagem> __Method_VerificaEntrada = new grpc::Method<global::GrpcServer.JogadorIdentidade, global::GrpcServer.JogadorMensagem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VerificaEntrada",
        __Marshaller_JogadorIdentidade,
        __Marshaller_JogadorMensagem);

    static readonly grpc::Method<global::GrpcServer.JogadorAposta, global::GrpcServer.JogadorResultadoAposta> __Method_RecebeApostaChave = new grpc::Method<global::GrpcServer.JogadorAposta, global::GrpcServer.JogadorResultadoAposta>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RecebeApostaChave",
        __Marshaller_JogadorAposta,
        __Marshaller_JogadorResultadoAposta);

    static readonly grpc::Method<global::GrpcServer.JogadorDados, global::GrpcServer.JogadorChavesAnteriores> __Method_VerApostas = new grpc::Method<global::GrpcServer.JogadorDados, global::GrpcServer.JogadorChavesAnteriores>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "VerApostas",
        __Marshaller_JogadorDados,
        __Marshaller_JogadorChavesAnteriores);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.JogadoresReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Jogador</summary>
    [grpc::BindServiceMethod(typeof(Jogador), "BindService")]
    public abstract partial class JogadorBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.JogadorMensagem> VerificaEntrada(global::GrpcServer.JogadorIdentidade request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.JogadorResultadoAposta> RecebeApostaChave(global::GrpcServer.JogadorAposta request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task VerApostas(global::GrpcServer.JogadorDados request, grpc::IServerStreamWriter<global::GrpcServer.JogadorChavesAnteriores> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(JogadorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_VerificaEntrada, serviceImpl.VerificaEntrada)
          .AddMethod(__Method_RecebeApostaChave, serviceImpl.RecebeApostaChave)
          .AddMethod(__Method_VerApostas, serviceImpl.VerApostas).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, JogadorBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_VerificaEntrada, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.JogadorIdentidade, global::GrpcServer.JogadorMensagem>(serviceImpl.VerificaEntrada));
      serviceBinder.AddMethod(__Method_RecebeApostaChave, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.JogadorAposta, global::GrpcServer.JogadorResultadoAposta>(serviceImpl.RecebeApostaChave));
      serviceBinder.AddMethod(__Method_VerApostas, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcServer.JogadorDados, global::GrpcServer.JogadorChavesAnteriores>(serviceImpl.VerApostas));
    }

  }
}
#endregion
