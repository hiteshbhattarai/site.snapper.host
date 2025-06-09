using site.snapper.dynamo.Models.Tables.Project;

namespace site.snapper.dynamo
{
    public class ProjectBaseModel : SystemMetadata
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public Status Status { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<ProjectCheckList> ProjectCheckLists { get; set; }
        public ICollection<ProjectTask> ProjectTasks { get; set; }

        public ICollection<Label> Labels { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
