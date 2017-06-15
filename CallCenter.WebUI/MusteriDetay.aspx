<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MusteriDetay.aspx.cs" Inherits="CallCenter.WebUI.MusteriDetay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>
        <asp:Literal ID="ltMusteriAdi" runat="server" /></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-horizontal">
                <div class="form-group">
                    <label>Ad</label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txtAd" />

                </div>
                <div class="form-group">
                    <label>Soyad</label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txtSoyad" />
                </div>

                <div class="form-group">
                    <label>TC</label>

                    <asp:TextBox CssClass="form-control" runat="server" ID="txtTc" />

                </div>

                <div class="form-group">
                    <label>Doğum Tarihi</label>

                    <asp:TextBox CssClass="form-control" runat="server" ID="txtDogumTarihi" TextMode="Date" />

                </div>

            </div>

            <fieldset class="col-sm-4">
                <legend>Telefon</legend>
                <asp:Repeater ID="rptTelefonlar" runat="server"  OnItemCommand="rptTelefonlar_ItemCommand">
                    <HeaderTemplate>
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>Telefon Numarası</th>
                                    <th>
                                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#telefonEkle"><i class="glyphicon glyphicon-plus"></i></button>
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("TelefonNumarasi") %></td>
                            <td>
                                <asp:LinkButton CommandArgument='<%# Eval("TelefonID") %>' CommandName="Sil" CssClass="btn btn-danger" Text="Numara Sil" runat="server" OnClientClick="return confirm(&quot;Silmek İstiyormusunuz? &quot;)" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                </table>
                    </FooterTemplate>
                </asp:Repeater>

                <!-- Modal -->
                <div id="telefonEkle" class="modal fade" role="dialog">
                    <div class="modal-dialog">

                        <!-- Modal content-->
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h4 class="modal-title">Yeni Telefon Ekle</h4>
                            </div>

                            <div class="modal-body">
                                <div class="form-horizontal">

                                    <div class="form-group">
                                        <label class="col-sm-3 control-label">Telefon Numarası</label>
                                        <div class="col-sm-9">
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtTelefon" />
                                        </div>
                                    </div>


                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="btnTelefonKaydet" CssClass="btn btn-primary" Text="Telefon Ekle" runat="server" OnClick="btnTelefonKaydet_Click" />
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </fieldset>
            <fieldset class="col-sm-4">
                <legend>Mail</legend>
                <asp:Repeater ID="rptMailler" runat="server" OnItemCommand="rptMailler_ItemCommand">
                    <HeaderTemplate>
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>E-Posta</th>
                                    <th>
                                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#mailEkle"><i class="glyphicon glyphicon-plus"></i></button>
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("MailAdresi") %></td>
                            <td>
                                <asp:LinkButton CommandArgument='<%# Eval("MailID") %>' CommandName="Sil" CssClass="btn btn-danger" Text="Mail Sil" runat="server" OnClientClick="return confirm(&quot;Silmek İstiyormusunuz? &quot;)" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                </table>
                    </FooterTemplate>
                </asp:Repeater>

                <!-- Modal -->
                <div id="mailEkle" class="modal fade" role="dialog">
                    <div class="modal-dialog">

                        <!-- Modal content-->
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h4 class="modal-title">Yeni Mail Ekle</h4>
                            </div>

                            <div class="modal-body">
                                <div class="form-horizontal">

                                    <div class="form-group">
                                        <label class="col-sm-3 control-label">Mail Adresi</label>
                                        <div class="col-sm-9">
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtMail" />
                                        </div>
                                    </div>


                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="btnMailKaydet" CssClass="btn btn-primary" Text="Mail Ekle" runat="server" OnClick="btnMailKaydet_Click" />
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

            </fieldset>
            <fieldset class="col-sm-4">
                <legend>Adres</legend>
                <asp:Repeater ID="rptAdresler" runat="server" OnItemCommand="rptAdresler_ItemCommand">
                    <HeaderTemplate>
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>Adres</th>
                                    <th>
                                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#adresEkle"><i class="glyphicon glyphicon-plus"></i></button>
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Adresi") %></td>
                            <td>
                                <asp:LinkButton CommandArgument='<%# Eval("AdresID") %>' CommandName="Sil" CssClass="btn btn-danger" Text="Adres Sil" runat="server" OnClientClick="return confirm(&quot;Silmek İstiyormusunuz? &quot;)" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                </table>
                    </FooterTemplate>
                </asp:Repeater>

                <!-- Modal -->
                <div id="adresEkle" class="modal fade" role="dialog">
                    <div class="modal-dialog">

                        <!-- Modal content-->
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h4 class="modal-title">Yeni Adres Ekle</h4>
                            </div>

                            <div class="modal-body">
                                <div class="form-horizontal">

                                    <div class="form-group">
                                        <label class="col-sm-3 control-label">Adres</label>
                                        <div class="col-sm-9">
                                            <asp:TextBox CssClass="form-control" runat="server" ID="txtAdres" />
                                        </div>
                                    </div>


                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="btnAdresKaydet" CssClass="btn btn-primary" Text="Adres Ekle" runat="server" OnClick="btnAdresKaydet_Click" />
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="col-sm-3">
        <asp:Button ID="btnGeri" runat="server" Text="Geri Dön" class="btn btn-primary" OnClick="btnGeri_Click" />

        </div>
    </form>
</body>
</html>
