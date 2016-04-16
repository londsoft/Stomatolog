using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stomatolog.Domain.Models
{
    enum Type
    {
        Brak = 0,
        KropkaOtwarta = 1,
        KropkaZamknięta = 2,
        KwadratOtwarty = 3,
        KwadratZmknięty = 4,
        ZnakB = 5,
        ZnakEx = 6
    }

    enum State
    {
        Brak = 0,
        Prochnica = 1,
        Wypelnienie = 2,
        DoUsuniecia = 3,
        Korona = 4,
        PrzesloMostu = 5,
        FilarMostu = 6
    }
}
