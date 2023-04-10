// ******************************************************************************
//  © 2020 Sebastiaan Dammann | damsteen.nl
//
//  File:           : IAppFixture.cs
//  Project         : RetroTime.Web.Tests.Integration
// ******************************************************************************

namespace RetroTime.Web.Tests.Integration.Common;

using System.Threading.Tasks;

public interface IAppFixture
{
    ReturnAppFactory App { get; set; }

    Task OnInitialized();
}
