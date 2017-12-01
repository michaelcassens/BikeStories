<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="~/Main.master" %>

            
            <asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <!-- maincontent Starts -->
            <div class="maincontent">
                <!-- container starts -->
                <div class="container">
                	<div class="details">
                    	<ul>
                        	<li>
                            	<h2> Daily Story </h2>

                                <p>
                                    <asp:Label ID="lblDailyStory" runat="server"></asp:Label>
                                
                            </li>
                            <li class="last">
                            	<h2> What We Do </h2>
                                <p> Everyone remembers their first experience on a bike.  We want you to share those experiences.
                                    We want you to share your current experiences.  Riding a bike is freedom.  It's peace.  It's pure joy.  
                                    This isn't a forum for comments, likes, dislikes, etc.  We just want to share our stories so that others can read them
                                    and you can remember them. 

                                </p>
                            	
                            </li>
                        </ul>
                        <div class="clear"></div>
                    </div>
                    
                    
                </div>
                <!-- container ends -->
            </div>
            <!-- maincontent ends -->
            
          </asp:Content>