using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectReminder
{
    [Table("Notes")]
    public class Note
    {
        public int Id { get; set; }
        public string Description  { get; set; }

        public int IdProjet{ get; set; }



    }
}