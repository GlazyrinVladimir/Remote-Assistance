

namespace GoogleARCore.Examples.CloudAnchors
{
    using System;
    using UnityEngine;
    using UnityEngine.Networking;

    /// <summary>
    /// A NetworkManager that handles client connection and disconnection with customizable actions.
    /// </summary>
#pragma warning disable 618
    public class CloudAnchorsNetworkManager : NetworkManager
#pragma warning restore 618
    {
        /// <summary>
        /// Action which get called when the client connects to a server.
        /// </summary>
        public event Action OnClientConnected;

        /// <summary>
        /// Action which get called when the client disconnects from a server.
        /// </summary>
        public event Action OnClientDisconnected;

        /// <summary>
        /// Called on the client when connected to a server.
        /// </summary>
        /// <param name="conn">Connection to the server.</param>
#pragma warning disable 618
        public override void OnClientConnect(NetworkConnection conn)
#pragma warning restore 618
        {
            base.OnClientConnect(conn);
            if (conn.lastError == NetworkError.Ok)
            {
                Debug.Log("Successfully connected to server.");
            }
            else
            {
                Debug.LogError("Connected to server with error: " + conn.lastError);
            }

            if (OnClientConnected != null)
            {
                OnClientConnected();
            }
        }

        /// <summary>
        /// Called on the client when disconnected from a server.
        /// </summary>
        /// <param name="conn">Connection to the server.</param>
#pragma warning disable 618
        public override void OnClientDisconnect(NetworkConnection conn)
#pragma warning restore 618
        {
            base.OnClientDisconnect(conn);
            if (conn.lastError == NetworkError.Ok)
            {
                Debug.Log("Successfully disconnected from the server.");
            }
            else
            {
                Debug.LogError("Disconnected from the server with error: " + conn.lastError);
            }

            if (OnClientDisconnected != null)
            {
                OnClientDisconnected();
            }
        }
    }
}
