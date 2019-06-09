// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MossRequest.cs" company="NWACC">
//  The MIT License (MIT)
//
//  Copyright (c) 2014 Shane Carroll May
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// </copyright>
// <summary>
//   Represents a MOSS Request
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MossApp
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;

    using MossApp.Properties;

    /// <summary>
    /// Models a Moss (for a Measure Of Software Similarity) Request. 
    /// </summary>
    /// <remarks>
    /// The comments regarding the options for the request are copied directly from the 
    /// MOSS documentation (http://moss.stanford.edu/general/scripts/mossnet) denoted by ++
    /// </remarks>
    public sealed class MossRequest
    {
        /// <summary>
        /// The file upload format string. 
        /// </summary>
        private const string FileUploadFormat = "file {0} {1} {2} {3}\n";

        /// <summary>
        /// The default maximum matches
        /// </summary>
        private const int DefaultMaxMatches = 10;

        /// <summary>
        /// The default number of results to show
        /// </summary>
        private const int DefaultNumberOfResultsToShow = 250;

        /// <summary>
        /// The language for this request. 
        /// </summary>
        /// <remarks>
        /// ++ The -l option specifies the source language of the tested programs. 
        /// Moss supports many different languages
        /// See Properties.Settings.Default.Languages
        /// </remarks>
        private string language;

        /// <summary>
        /// The comments for this request.
        /// </summary>
        /// <remarks>
        /// ++ The -c option supplies a comment string that is attached to the generated 
        /// report.  This option facilitates matching queries submitted with replies 
        /// received, especially when several queries are submitted at once.
        /// </remarks>
        private string comments;

        /// <summary>
        /// Initializes a new instance of the <see cref="MossRequest"/> class.
        /// </summary>
        public MossRequest()
        {
            this.Files = new List<string>();
            this.BaseFile = new List<string>();
            this.UserId = 0;
            this.Server = Settings.Default.Server;
            this.Port = Settings.Default.Port;
            this.language = string.Empty;
            this.comments = string.Empty;
            this.MaxMatches = DefaultMaxMatches;
            this.NumberOfResultsToShow = DefaultNumberOfResultsToShow;
            this.IsDirectoryMode = false;
            this.IsBetaRequest = false;
        }

        /// <summary>
        /// Gets or sets the maximum matches.
        /// </summary>
        /// <value>
        /// The maximum matches.
        /// </value>
        /// <remarks>
        /// ++ The -m option sets the maximum number of times a given passage may appear 
        /// before it is ignored.  A passage of code that appears in many programs 
        /// is probably legitimate sharing and not the result of plagiarism.  With -m N, 
        /// any passage appearing in more than N programs is treated as if it appeared in 
        /// a base file (i.e., it is never reported).  Option -m can be used to control 
        /// moss' sensitivity.  With -m 2, moss reports only passages that appear 
        /// in exactly two programs.  If one expects many very similar solutions 
        /// (e.g., the short first assignments typical of introductory programming courses) 
        /// then using -m 3 or -m 4 is a good way to eliminate all but 
        /// truly unusual matches between programs while still being able to detect 
        /// 3-way or 4-way plagiarism.  With -m 1000000 (or any very large number), 
        /// moss reports all matches, no matter how often they appear.  
        /// The -m setting is most useful for large assignments where one also a base file 
        /// expected to hold all legitimately shared code.  
        /// The default for -m is 3.
        /// </remarks>
        public int MaxMatches { get; set; }

        /// <summary>
        /// Gets an object representing the collection of the Source File(s) contained in this Request.
        /// </summary>
        /// <value>
        /// The files.
        /// </value>
        /// <remarks>
        /// This property enables you to obtain a reference to the list of Source File(s) that are currently stored in the Request. 
        /// With this reference, you can add items, remove items, and obtain a count of the Files in the Request.
        /// </remarks>
        public List<string> Files { get; private set; }

        /// <summary>
        /// Gets an object representing the collection of the Base File(s) contained in this Request.
        /// </summary>
        /// <value>
        /// The base file.
        /// </value>
        /// <remarks>
        /// This property enables you to obtain a reference to the list of Base File(s) that are currently stored in the Request. 
        /// With this reference, you can add items, remove items, and obtain a count of the Files in the Request.
        /// ++ The -b option names a "base file".  Moss normally reports all code 
        /// that matches in pairs of files.  When a base file is supplied, 
        /// program code that also appears in the base file is not counted in matches. 
        /// A typical base file will include, for example, the instructor-supplied 
        /// code for an assignment.  Multiple -b options are allowed.  You should u
        /// se a base file if it is convenient; base files improve results, but 
        /// are not usually necessary for obtaining useful information. 
        /// IMPORTANT: Unlike previous versions of moss, the -b option *always* 
        /// takes a single filename,
        /// </remarks>
        public List<string> BaseFile { get; private set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is beta request.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is beta request; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>
        /// ++ Represents the -x option sends queries to the current experimental version of the server. 
        /// The experimental server has the most recent Moss features and is also usually 
        /// less stable (read: may have more bugs).
        /// </remarks>
        public bool IsBetaRequest { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is directory mode.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is directory mode; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>
        /// ++ The -d option specifies that submissions are by directory, not by file. 
        /// That is, files in a directory are taken to be part of the same program, 
        /// and reported matches are organized accordingly by directory.
        /// </remarks>
        public bool IsDirectoryMode { get; set; }

        /// <summary>
        /// Gets or sets the number of results to show.
        /// </summary>
        /// <value>
        /// The number of results to show.
        /// </value>
        /// <remarks>
        /// The -n option determines the number of matching files to show in the results. 
        /// The default is 250.
        /// </remarks>
        public int NumberOfResultsToShow { get; set; }

        /// <summary>
        /// Gets or sets the language for this request
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        /// <remarks>
        /// ++ The -l option specifies the source language of the tested programs. 
        /// Moss supports many different languages
        /// See Properties.Settings.Default.Languages
        /// </remarks>
        public string Language
        {
            get => this.language;

            set => this.language = value ?? string.Empty;
        }

        /// <summary>
        /// Gets or sets the comments for the request.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        /// <remarks>
        /// ++ The -c option supplies a comment string that is attached to the generated 
        /// report.  This option facilitates matching queries submitted with replies 
        /// received, especially when several queries are submitted at once.
        /// </remarks>
        public string Comments
        {
            get => this.comments;

            set => this.comments = value ?? string.Empty;
        }

        /// <summary>
        /// Gets or sets the server.
        /// </summary>
        /// <value>
        /// The server.
        /// </value>
        private string Server { get; set; }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        private int Port { get; set; }

        /// <summary>
        /// Gets or sets the moss socket.
        /// </summary>
        /// <value>
        /// The moss socket.
        /// </value>
        private Socket MossSocket { get; set; }

        /// <summary>
        /// Gets or sets the size of the response byte array.
        /// </summary>
        /// <value>
        /// The size of the response byte array.
        /// </value>
        private int ReplySize { get; set; } = 512;

        /// <summary>
        /// Sends the request.
        /// </summary>
        /// <param name="response">The response from the request.</param>
        /// <returns>
        /// <code>true</code> if the response was successful, otherwise <code>false</code>
        /// </returns>
        /// <remarks>
        /// If the request is successful, <code>true</code> is returned, then response is a valid <see cref="System.Uri"/>
        /// </remarks>
        public bool SendRequest(out string response)
        {
            try
            {
                var hostEntry = Dns.GetHostEntry(this.Server);
                var address = hostEntry.AddressList[0];
                var ipe = new IPEndPoint(address, this.Port);
                string result;
                using (var socket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
                {
                    socket.Connect(ipe);

                    this.SendOption(
                        Settings.Default.MossOption,
                        this.UserId.ToString(CultureInfo.InvariantCulture),
                        socket);
                    this.SendOption(Settings.Default.DirectoryOption, this.IsDirectoryMode ? "1" : "0", socket);
                    this.SendOption(Settings.Default.ExperimentalOption, this.IsBetaRequest ? "1" : "0", socket);
                    this.SendOption(
                        Settings.Default.MaxMatchesOption,
                        this.MaxMatches.ToString(CultureInfo.InvariantCulture),
                        socket);
                    this.SendOption(
                        Settings.Default.ShowOption,
                        this.NumberOfResultsToShow.ToString(CultureInfo.InvariantCulture),
                        socket);

                    if (this.BaseFile.Count != 0)
                    {
                        foreach (var file in this.BaseFile)
                        {
                            this.SendFile(file, socket, 0);
                        }
                    } // else, no base files to send DoNothing();

                    if (this.Files.Count != 0)
                    {
                        int fileCount = 1;
                        foreach (var file in this.Files)
                        {
                            this.SendFile(file, socket, fileCount++);
                        }
                    } // else, no files to send DoNothing();

                    this.SendOption("query 0", this.Comments, socket);

                    var bytes = new byte[this.ReplySize];
                    socket.Receive(bytes);

                    result = Encoding.UTF8.GetString(bytes);
                    this.SendOption(Settings.Default.EndOption, string.Empty, socket);
                }

                if (Uri.TryCreate(result, UriKind.Absolute, out var url))
                {
                    response = url?.ToString().IndexOf("\n", System.StringComparison.Ordinal) > 0
                                   ? url.ToString().Split('\n')[0]
                                   : url?.ToString();
                    return true;
                } // else, not a valid URL, DoNothing();

                response = Resources.Moss_Request_URI_Error;
                return false;
            }
            catch (Exception ex)
            {
                // TODO Change from exception never catch exception...
                response = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Sends the argument using the given socket.
        /// </summary>
        /// <param name="option">The option.</param>
        /// <param name="value">The value of the argument.</param>
        /// <param name="socket">The OPEN socket.</param>
        /// <remarks>
        /// Assumes that the socket is open!
        /// </remarks>
        private void SendOption(string option, string value, Socket socket)
        {
            socket.Send(Encoding.UTF8.GetBytes($"{option} {value}\n"));
        }

        /// <summary>
        /// Sends the file using the given socket.
        /// </summary>
        /// <param name="file">The file to send.</param>
        /// <param name="socket">The OPEN socket.</param>
        /// <param name="number">A unique id number for the file.</param>
        /// <remarks>
        /// Assumes that the socket is open!
        /// </remarks>
        private void SendFile(string file, Socket socket, int number)
        {
            var fileInfo = new FileInfo(file);
            socket.Send(
                this.IsDirectoryMode
                    ? Encoding.UTF8.GetBytes(
                        string.Format(
                            FileUploadFormat,
                            number,
                            this.language,
                            fileInfo.Length,
                            fileInfo.FullName.Replace("\\", "/").Replace(" ", string.Empty)))
                    : Encoding.UTF8.GetBytes(
                        string.Format(
                            FileUploadFormat,
                            number,
                            this.language,
                            fileInfo.Length,
                            fileInfo.Name.Replace(" ", string.Empty))));
            Console.WriteLine(fileInfo.FullName.Replace("\\", "/").Replace(" ", string.Empty));
            socket.BeginSendFile(file, FileSendCallback, socket);
        }

        private static void FileSendCallback(IAsyncResult result)
        {
            var client = result.AsyncState as Socket;
            client?.EndSendFile(result);
        }
    }
}