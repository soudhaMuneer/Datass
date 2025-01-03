namespace SampleAPI.Model
{
    public class CreateTableRequest
    {
        public string TableName { get; set; }
        public List<TableField> Fields { get; set; }
    }
}
