namespace site.snapper.dynamo
{
    public class SystemMetadata
    {
        public By CreatedBy { get; set; }
        public By UpdatedBy { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Status Status { get; set; }


    }

    public class By {
        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public string DisplayName { get; set; }

        public string EmailAddress { get; set; }
    }
}
