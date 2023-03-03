//interface de servicio para ser accedida como rest y poder entregar informacion de calculos de proceso
//de datos relacionados con los clientes


function clientStruct getDataClient(IdentifierClient idClient)
{
    ServiceClient serviceClient = getServiceClient();
    DataClient dataClient = serviceClient.getClientData(idClient);
    ProcessService proccesService = getClientProccess();
    TaxesData taxesData = proccesService.CalulateTaxesData(dataClient);
}

function clientStruct getDataClient2(IdentifierClient idClient)
{
   return ner clientStruct();
}

function clientStruct getDataClient3(IdentifierClient idClient)
{
   return ner clientStruct();
}