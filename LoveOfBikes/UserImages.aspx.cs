﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserImages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    //private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
    //{
    //    int sourceWidth = imgToResize.Width;
    //    int sourceHeight = imgToResize.Height;

    //    float nPercent = 0;
    //    float nPercentW = 0;
    //    float nPercentH = 0;

    //    nPercentW = ((float)size.Width / (float)sourceWidth);
    //    nPercentH = ((float)size.Height / (float)sourceHeight);

    //    if (nPercentH < nPercentW)
    //        nPercent = nPercentH;
    //    else
    //        nPercent = nPercentW;

    //    int destWidth = (int)(sourceWidth * nPercent);
    //    int destHeight = (int)(sourceHeight * nPercent);

    //    Bitmap b = new Bitmap(destWidth, destHeight);
    //    Graphics g = Graphics.FromImage((System.Drawing.Image)b);
    //    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

    //    g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
    //    g.Dispose();

    //    return (System.Drawing.Image)b;
    //}
}