// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Customers.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Protos {
  public static partial class Customer
  {
    static readonly string __ServiceName = "Customer";

    static readonly grpc::Marshaller<global::GrpcService.Protos.CustomerLookupModel> __Marshaller_CustomerLookupModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.CustomerLookupModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.CustomerModel> __Marshaller_CustomerModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.CustomerModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.NewCustomerRequest> __Marshaller_NewCustomerRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.NewCustomerRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.Protos.CustomerLookupModel, global::GrpcService.Protos.CustomerModel> __Method_GetCustomerInfo = new grpc::Method<global::GrpcService.Protos.CustomerLookupModel, global::GrpcService.Protos.CustomerModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerInfo",
        __Marshaller_CustomerLookupModel,
        __Marshaller_CustomerModel);

    static readonly grpc::Method<global::GrpcService.Protos.NewCustomerRequest, global::GrpcService.Protos.CustomerModel> __Method_GetNewCustomers = new grpc::Method<global::GrpcService.Protos.NewCustomerRequest, global::GrpcService.Protos.CustomerModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetNewCustomers",
        __Marshaller_NewCustomerRequest,
        __Marshaller_CustomerModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.CustomersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Customer</summary>
    [grpc::BindServiceMethod(typeof(Customer), "BindService")]
    public abstract partial class CustomerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.CustomerModel> GetCustomerInfo(global::GrpcService.Protos.CustomerLookupModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetNewCustomers(global::GrpcService.Protos.NewCustomerRequest request, grpc::IServerStreamWriter<global::GrpcService.Protos.CustomerModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerInfo, serviceImpl.GetCustomerInfo)
          .AddMethod(__Method_GetNewCustomers, serviceImpl.GetNewCustomers).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomerInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.CustomerLookupModel, global::GrpcService.Protos.CustomerModel>(serviceImpl.GetCustomerInfo));
      serviceBinder.AddMethod(__Method_GetNewCustomers, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcService.Protos.NewCustomerRequest, global::GrpcService.Protos.CustomerModel>(serviceImpl.GetNewCustomers));
    }

  }
}
#endregion