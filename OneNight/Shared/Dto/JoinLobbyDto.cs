using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNight.Shared.Dto;
public class JoinLobbyDto
{
    public string GameId { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;
}
