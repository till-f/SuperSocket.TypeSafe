﻿using NetMessage.Base.Packets;
using System.Threading.Tasks;

namespace NetMessage.Examples.SimpleString
{
  /// <summary>
  /// Request for the <see cref="SimpleStringProtocol"/>.
  /// Note that the Respond method simply forwards to the protected method of the generic base class.
  /// </summary>
  public class SimpleStringRequest : Request<SimpleStringRequest, SimpleStringProtocol, string>
  {
    public SimpleStringRequest(string request, int requestId) : base(request, requestId)
    {
    }

    public Task<int> SendResponseAsync(string response)
    {
      return SendResponseInternalAsync(response);
    }
  }
}
