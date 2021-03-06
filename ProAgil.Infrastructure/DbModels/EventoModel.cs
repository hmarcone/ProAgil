﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.Infrastructure.DbModels
{
	public class EventoModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "O Tema deve ser Preeenchido")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O Local é obrigatório")]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "Local é entre 3 e 100 caracteres")]
		public string Local { get; set; }
		public string DataEvento { get; set; }

		[Range(2, 120000, ErrorMessage = "Quatidade de Pessoas é entre 2 e 120000")]
		public int QtdPessoas { get; set; }
		public string ImagemURL { get; set; }

		[Phone]
		public string Telefone { get; set; }

		[EmailAddress]
		public string Email { get; set; }
		public List<LoteModel> Lotes { get; set; }
		public List<RedeSocialModel> RedesSociais { get; set; }
		public List<PalestranteModel> Palestrantes { get; set; }

	}
}
