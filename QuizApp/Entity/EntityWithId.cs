using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp
{
	public class EntityWithId
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

	}

}
