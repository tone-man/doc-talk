
using PipelineCore;

namespace PipelineConvai {

    /// <summary>
    /// Represents a response message from Convai's Character API
    /// 
    /// author: Antonio Craveiro
    /// </summary>
    class TextResponse : ResponseInterface {

        private string ConvaiAPIKey; // API Key for header
        private int CharID; // Character ID
        private int SessionID; // Session ID, for tracking conversation
        private bool VoiceResponse; // Flag for audio or text data
        private string Audio; // The audio returned from the model
        private string UserText; // THe text sent to the endpoint
        private string Text; // The text returned form the model

        /// <summary>
        /// Builds and returns a response message.
        /// </summary>
        /// <returns>The constructed response message.</returns>
        ResponseMessage<T> BuildResponse() {

        }

        /// <summary>
        /// Gets the value contained in the response message.
        /// </summary>
        /// <returns>The value contained in the response message.</returns>
        T GetValue() {
            if (VoiceResponse) {
                return Audio;
            } else {
                return Text;
            }
        }
    }
}