using private_proxy_unsafe_accessor;

var privateAccessProxy = new PrivateAccess();

privateAccessProxy.AsPrivateProxy()._counter = 5;
privateAccessProxy.AsPrivateProxy().Increment();
privateAccessProxy.AsPrivateProxy().Show();

ref var counter = ref PrivateAccessProxy.GetInstanceCounter(ref privateAccessProxy);

counter = 100;
privateAccessProxy.AsPrivateProxy().Increment();
privateAccessProxy.AsPrivateProxy().Show();
