using CosmicAdventureDTO;
using System.ServiceModel;

namespace CosmosWcfServiceLibrary
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface ICosmosWcf
    {
        [OperationContract]
        void InitializeGame();

        [OperationContract]
        Starship SendStarship(Starship starship, string systemName);

        [OperationContract]
        SpaceSystem GetSystem();

        [OperationContract]
        Starship GetStarship(int money);

        // TODO: dodaj tutaj operacje usługi
    }
}
