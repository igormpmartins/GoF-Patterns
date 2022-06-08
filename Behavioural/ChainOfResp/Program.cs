using ChainOfResp;

var poSystem = new POSystem();
poSystem.ProcessRequest(1000);
poSystem.ProcessRequest(20000);
poSystem.ProcessRequest(300000);
