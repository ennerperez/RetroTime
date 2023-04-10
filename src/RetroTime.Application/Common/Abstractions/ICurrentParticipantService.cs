// ******************************************************************************
//  © 2019 Sebastiaan Dammann | damsteen.nl
//
//  File:           : ICurrentParticipantService.cs
//  Project         : RetroTime.Application
// ******************************************************************************

namespace RetroTime.Application.Common.Abstractions;

using System.Threading.Tasks;
using Models;

public interface ICurrentParticipantService {
    ValueTask<CurrentParticipantModel> GetParticipant();
    void SetParticipant(CurrentParticipantModel participant);
}
