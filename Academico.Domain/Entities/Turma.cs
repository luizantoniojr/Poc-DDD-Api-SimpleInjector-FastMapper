﻿using System;
using System.Collections.Generic;

namespace Academico.Domain.Entities
{
    public class Turma
    {
        public Turma()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual IEnumerable<Discente> Discentes { get; set; }
        public virtual ICollection<Docente> Docentes { get; set; }
    }
}