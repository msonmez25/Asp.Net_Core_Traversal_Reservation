namespace TraversalCoreProje.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIDQuery
    {
        public GetDestinationByIDQuery(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; set; }
    }
}
