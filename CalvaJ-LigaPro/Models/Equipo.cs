﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CalvaJ_LigaPro.Models
{
    // Ctrl+A,Ctrl+K, Ctrl+F to format the code
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Nombre del equipo")]
        [Required]
        public string Nombre { get; set; }
        [Range(0, 20)]
        [DisplayName("Partidos Jugados")]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        [DisplayName("Partidos Ganados")]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        [DisplayName("Partidos Empatados")]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        [DisplayName("Partidos Perdidos")]
        public int PartidosPerdidos { get; set; }
        [DisplayName("Puntos")]
        public int Puntos { 
            get 
            {
                int puntos = PartidosGanados * 3 + PartidosEmpatados;
                return puntos;
            } 
        }
    }
}
