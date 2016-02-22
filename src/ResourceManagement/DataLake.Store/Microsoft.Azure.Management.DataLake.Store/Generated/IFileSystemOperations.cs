// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// FileSystemOperations operations.
    /// </summary>
    public partial interface IFileSystemOperations
    {
        /// <summary>
        /// Appends to the file specified. This method supports multiple
        /// concurrent appends to the file. NOTE: that concurrent append and
        /// serial append CANNOT be used interchangeably. Once a file has
        /// been appended to using either one, it can only be appended to
        /// using that type of append.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to append to using concurrent append.
        /// </param>
        /// <param name='accountname'>
        /// The name of the data lake account that the file lives in.
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when appending to the file.
        /// </param>
        /// <param name='appendMode'>
        /// Indicates the concurrent append call should create the file if it
        /// doesn't exist or just open the existing file for append
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> ConcurrentAppendWithHttpMessagesAsync(string filePath, string accountname, System.IO.Stream streamContents, object appendMode = default(object), string op = "CONCURRENTAPPEND", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks if the specified access is available at the given path.
        /// </summary>
        /// <param name='path'>
        /// The path to the file or folder to check access for.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='fsaction'>
        /// File system operation read/write/execute in string form, matching
        /// regex pattern '[rwx-]{3}'
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> CheckAccessWithHttpMessagesAsync(string path, string accountname, string fsaction = default(string), string op = "CHECKACCESS", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a directory.
        /// </summary>
        /// <param name='path'>
        /// The path to the directory to create.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='permission'>
        /// The optional permissions to set on the directories
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FileOperationResult>> MkdirsWithHttpMessagesAsync(string path, string accountname, string permission = default(string), string op = "MKDIRS", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Concatenates the list of files into the target file.
        /// </summary>
        /// <param name='destinationPath'>
        /// The path to the destination file resulting from the concatenation.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='sources'>
        /// A list of comma seperated absolute FileSystem paths without scheme
        /// and authority
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> ConcatWithHttpMessagesAsync(string destinationPath, string accountname, string sources = default(string), string op = "CONCAT", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Concatenates the list of files into the target file. This API is
        /// NOT webhdfs compliant, however supports a much larger list of
        /// files in the concatenate list.
        /// </summary>
        /// <param name='msConcatDestinationPath'>
        /// The path to the destination file resulting from the concatenation.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='streamContents'>
        /// A list of comma seperated absolute FileSystem paths without scheme
        /// and authority. In the format: 'sources=&lt;comma separated
        /// list&gt;'
        /// </param>
        /// <param name='deletesourcedirectory'>
        /// Indicates two things to the system which allow for optimizations
        /// and increased concatenate performance. First, that all the
        /// streams being concatenated are in the same source directory.
        /// Second, that the source directory ONLY has streams in it that are
        /// being concatenated into the destination stream. Note that only
        /// the first requirement is strictly enforced (concatenate will
        /// ignore the flag and only delete the source streams, not the
        /// folder). If the first option is met, ALL data that was not part
        /// of the set of streams being concatenated WILL BE LOST. It is
        /// critical to only use this option if you are certain the two
        /// requirements are met.
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> MsConcatWithHttpMessagesAsync(string msConcatDestinationPath, string accountname, System.IO.Stream streamContents, bool? deletesourcedirectory = default(bool?), string op = "MSCONCAT", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the list of file status objects specified by the file path.
        /// </summary>
        /// <param name='listFilePath'>
        /// The path to the file to retrieve status for.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='top'>
        /// Gets or sets the number of items to return. Optional.
        /// </param>
        /// <param name='skip'>
        /// Gets or sets the number of items to skip over before returning
        /// elements. Optional.
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FileStatusesResult>> ListFileStatusWithHttpMessagesAsync(string listFilePath, string accountname, int? top = default(int?), int? skip = default(int?), string op = "LISTSTATUS", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the file content summary object specified by the file path.
        /// </summary>
        /// <param name='getContentSummaryFilePath'>
        /// The path to the file to retrieve the summary for.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ContentSummaryResult>> GetContentSummaryWithHttpMessagesAsync(string getContentSummaryFilePath, string accountname, string op = "GETCONTENTSUMMARY", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the file status object specified by the file path.
        /// </summary>
        /// <param name='getFilePath'>
        /// The path to the file to retrieve status for.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FileStatusResult>> GetFileStatusWithHttpMessagesAsync(string getFilePath, string accountname, string op = "GETFILESTATUS", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Directly appends to a file with the specified content, without
        /// requiring a redirect. This API is NOT webhdfs compliant. It
        /// should be used only by tools that do not rely on webhdfs
        /// interoperability.
        /// </summary>
        /// <param name='directFilePath'>
        /// The path to the file to append to.
        /// </param>
        /// <param name='accountname'>
        /// The name of the Data Lake Store account to append to the file in
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when appending to the file.
        /// </param>
        /// <param name='buffersize'>
        /// The optional buffer size to use when appending data
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='append'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> AppendWithHttpMessagesAsync(string directFilePath, string accountname, System.IO.Stream streamContents, long? buffersize = default(long?), string op = "APPEND", bool? append = true, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Directly creates a file with the specified content, without
        /// requiring a redirect. This API is NOT webhdfs compliant. It
        /// should be used only by tools that do not rely on webhdfs
        /// interoperability.
        /// </summary>
        /// <param name='directFilePath'>
        /// The path to the file to create.
        /// </param>
        /// <param name='accountname'>
        /// The name of the Data Lake Store account to create the file in
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when creating the file. This
        /// parameter is optional, resulting in an empty file if not
        /// specified.
        /// </param>
        /// <param name='buffersize'>
        /// The size of the buffer used in transferring data.
        /// </param>
        /// <param name='overwrite'>
        /// The indication of if the file should be overwritten.
        /// </param>
        /// <param name='blocksize'>
        /// The block size of a file, in bytes.
        /// </param>
        /// <param name='replication'>
        /// The number of replications of a file.
        /// </param>
        /// <param name='permission'>
        /// The permissions of a file or directory.
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='write'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> CreateWithHttpMessagesAsync(string directFilePath, string accountname, System.IO.Stream streamContents = default(System.IO.Stream), long? buffersize = default(long?), bool? overwrite = default(bool?), long? blocksize = default(long?), int? replication = default(int?), string permission = default(string), string op = "CREATE", bool? write = true, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Directly opens and reads from the specified file, without
        /// requiring a redirect. This API is NOT webhdfs compliant. It
        /// should be used only by tools that do not rely on webhdfs
        /// interoperability.
        /// </summary>
        /// <param name='directFilePath'>
        /// The path to the file to open.
        /// </param>
        /// <param name='accountname'>
        /// The name of the data lake account that the file lives in.
        /// </param>
        /// <param name='length'>
        /// </param>
        /// <param name='offset'>
        /// </param>
        /// <param name='buffersize'>
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='read'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<System.IO.Stream>> OpenWithHttpMessagesAsync(string directFilePath, string accountname, long? length = default(long?), long? offset = default(long?), long? buffersize = default(long?), string op = "OPEN", bool? read = true, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets ACL entries on a file or folder.
        /// </summary>
        /// <param name='setAclFilePath'>
        /// The path to the directory or file to set ACLs on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='aclspec'>
        /// The ACL spec included in ACL creation operations in the format
        /// '[default:]user|group|other::r|-w|-x|-'
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> SetAclWithHttpMessagesAsync(string setAclFilePath, string accountname, string aclspec, string op = "SETACL", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies existing ACL entries on a file or folder.
        /// </summary>
        /// <param name='modifyAclFilePath'>
        /// The path to the directory or file to modify ACLs on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='aclspec'>
        /// The ACL spec included in ACL modification operations in the format
        /// '[default:]user|group|other::r|-w|-x|-'
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> ModifyAclEntriesWithHttpMessagesAsync(string modifyAclFilePath, string accountname, string aclspec, string op = "MODIFYACLENTRIES", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes existing ACL entries on a file or folder.
        /// </summary>
        /// <param name='removeAclFilePath'>
        /// The path to the directory or file to remove ACLs on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='aclspec'>
        /// The ACL spec included in ACL removal operations in the format
        /// '[default:]user|group|other'
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> RemoveAclEntriesWithHttpMessagesAsync(string removeAclFilePath, string accountname, string aclspec, string op = "REMOVEACLENTRIES", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes default ACL entries on a file or folder.
        /// </summary>
        /// <param name='removeDefaultAclFilePath'>
        /// The path to the directory or file to remove ACL on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> RemoveDefaultAclWithHttpMessagesAsync(string removeDefaultAclFilePath, string accountname, string op = "REMOVEDEFAULTACL", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes the existing ACL on a file or folder.
        /// </summary>
        /// <param name='aclFilePath'>
        /// The path to the directory or file to remove ACL on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> RemoveAclWithHttpMessagesAsync(string aclFilePath, string accountname, string op = "REMOVEACL", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets ACL entries on a file or folder.
        /// </summary>
        /// <param name='aclFilePath'>
        /// The path to the directory or file to get ACLs on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AclStatusResult>> GetAclStatusWithHttpMessagesAsync(string aclFilePath, string accountname, string op = "GETACLSTATUS", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the requested file or folder, optionally recursively.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file or folder to delete.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='recursive'>
        /// The optional switch indicating if the delete should be recursive
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FileOperationResult>> DeleteWithHttpMessagesAsync(string filePath, string accountname, bool? recursive = default(bool?), string op = "DELETE", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a symbolic link.
        /// </summary>
        /// <param name='symLinkFilePath'>
        /// The path to the directory or file to create a symlink of.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='destination'>
        /// The path to create the symlink at
        /// </param>
        /// <param name='createParent'>
        /// If the parent directories do not exist, indicates if they should
        /// be created.
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> CreateSymLinkWithHttpMessagesAsync(string symLinkFilePath, string accountname, string destination, bool? createParent = false, string op = "CREATESYMLINK", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Rename a directory or file.
        /// </summary>
        /// <param name='renameFilePath'>
        /// The path to the directory to move/rename.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='destination'>
        /// The path to move/rename the file or folder to
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FileOperationResult>> RenameWithHttpMessagesAsync(string renameFilePath, string accountname, string destination, string op = "RENAME", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the owner of a file or folder.
        /// </summary>
        /// <param name='setOwnerFilePath'>
        /// The path to the directory or file to set the owner on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='owner'>
        /// The username who is the owner of a file/directory, if empty
        /// remains unchanged.
        /// </param>
        /// <param name='group'>
        /// The group who is the group owner of a file/directory, if empty
        /// remains unchanged.
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> SetOwnerWithHttpMessagesAsync(string setOwnerFilePath, string accountname, string owner = default(string), string group = default(string), string op = "SETOWNER", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the permission of the file or folder.
        /// </summary>
        /// <param name='setPermissionFilePath'>
        /// The path to the directory or file to set permissions on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='permission'>
        /// A string octal representation of the permission (i.e 'rwx'), if
        /// empty remains unchanged.
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> SetPermissionWithHttpMessagesAsync(string setPermissionFilePath, string accountname, string permission = default(string), string op = "SETPERMISSION", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the value of the replication factor.
        /// </summary>
        /// <param name='setReplicationFilePath'>
        /// The path to the directory or file to create a replication of.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='replication'>
        /// The number of replications of a file.
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FileOperationResult>> SetReplicationWithHttpMessagesAsync(string setReplicationFilePath, string accountname, int? replication = default(int?), string op = "SETREPLICATION", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the access or modification time on a file or folder.
        /// </summary>
        /// <param name='sourcePath'>
        /// The path to the directory or file to set permissions on.
        /// </param>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='modificationtime'>
        /// The modification time of a file/directory. If -1 remains unchanged
        /// </param>
        /// <param name='accesstime'>
        /// The access time of a file/directory. If -1 remains unchanged
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> SetTimesWithHttpMessagesAsync(string sourcePath, string accountname, long? modificationtime = default(long?), long? accesstime = default(long?), string op = "SETTIMES", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the home directory for the specified account.
        /// </summary>
        /// <param name='accountname'>
        /// The name of the account to use
        /// </param>
        /// <param name='op'>
        /// This is the REQUIRED value for this parameter and method
        /// combination. Changing the value will result in unexpected
        /// behavior, please do not do so.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<HomeDirectoryResult>> GetHomeDirectoryWithHttpMessagesAsync(string accountname, string op = "GETHOMEDIRECTORY", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
