<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SWFUploadDemo.aspx.cs" Inherits="Libary.UI.Demo.SWFUploadDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>SWFUpload Application Demo</title>
    <script src="../SWFUpload/swfupload.js"></script>
    <script src="../SWFUpload/handlers.js"></script>
    <script src="../Js/jquery-1.10.2.min.js"></script>
    <script type="text/javascript">
        var swfu;
        window.onload = function () {
            swfu = new SWFUpload({
                // Backend Settings
                upload_url: "/ashx/upload.ashx",
                post_params: {
                    "ASPSESSID": "<%=Session.SessionID %>"
                },

                // File Upload Settings
                file_size_limit: "2 MB",  //文件大小
                file_types: "*.jpg;*.gif",      //文件类型
                file_types_description: "JPG Images", //描述
                file_upload_limit: 0,    // Zero means unlimited

                // Event Handler Settings - these functions as defined in Handlers.js
                //  The handlers are not part of SWFUpload but are part of my website and control how
                //  my website reacts to the SWFUpload events.
                swfupload_preload_handler: preLoad,
                swfupload_load_failed_handler: loadFailed,
                file_queue_error_handler: fileQueueError,
                file_dialog_complete_handler: fileDialogComplete,
                upload_progress_handler: uploadProgress,
                upload_error_handler: uploadError,
                upload_success_handler: showImage,
                upload_complete_handler: uploadComplete,

                // Button settings
                button_image_url: "/SWFUpload/images/XPButtonNoText_160x22.png",
                button_placeholder_id: "spanButtonPlaceholder",
                button_width: 160,
                button_height: 22,
                button_text: '<span class="button">请选择上传图片<span class="buttonSmall">(2 MB Max)</span></span>',
                button_text_style: '.button { font-family: Helvetica, Arial, sans-serif; font-size: 14pt; } .buttonSmall { font-size: 10pt; }',
                button_text_top_padding: 1,
                button_text_left_padding: 5,

                // Flash Settings
                flash_url: "/SWFUpload/swfupload.swf",	// Relative to this file
                flash9_url: "/SWFUpload/swfupload_FP9.swf",	// Relative to this file

                custom_settings: {
                    upload_target: "divFileProgressContainer"
                },

                // Debug Settings
                debug: false
            });
        }

        //上传成功后调用该方法
        function showImage(file, serverData) {
            $("#imgSrc").attr("src", serverData);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="content">
            <div id="swfu_container" style="margin: 0px 10px;">
                <div>
                    <span id="spanButtonPlaceholder"></span>
                </div>
                <div id="divFileProgressContainer" style="height: 75px;"></div>
                <div id="thumbnails"></div>
                <img id="imgSrc" />
            </div>
        </div>
    </form>
</body>
</html>
