namespace CarMate.Common.Domain
{
    public interface IEntity
    {
        int Id
        {
            get;
            set;
        }

        bool IsDeleted
        {
            get;
            set;
        }

        EntityStatusType EntityStatus
        {
            get;
            set;
        }
    }
}
