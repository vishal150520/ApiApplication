namespace ApiApplication.models
{
    public class CommonEntityProperties
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set;} = DateTime.UtcNow;
        public string? ModifiedBy { get; set;}
        public DateTime? ModifiedDate { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
