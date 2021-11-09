using System.ComponentModel.DataAnnotations;

namespace GuitarStuff.Models
{
	public class Guitar
	{
		public int GuitarId { get; set; }
		[Required]
		[StringLength(20)]
		public string GuitarType { get; set; }
		[Required]
		public string GuitarPlayersAssociated { get; set; }
	}
}