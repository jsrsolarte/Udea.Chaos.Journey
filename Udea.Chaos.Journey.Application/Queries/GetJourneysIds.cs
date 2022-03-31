using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udea.Chaos.Journey.Application.Queries
{
    public record GetJourneysIds(): IRequest<IEnumerable<Guid>>;
}
