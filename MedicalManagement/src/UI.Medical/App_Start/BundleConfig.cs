using System.Web.Optimization;

namespace UI.Medical
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                    "~/tpl/plugins/core/pace/pace.min.js",
                    "~/tpl/js/libs/jquery-2.1.1.min.js",


                    "~/Scripts/jquery-ui-1.11.2.min.js",

                    "~/tpl/js/bootstrap/bootstrap.min.js",
                    "~/tpl/js/jRespond.min.js",
                    "~/tpl/plugins/core/slimscroll/jquery.slimscroll.min.js",
                    "~/tpl/plugins/core/slimscroll/jquery.slimscroll.horizontal.min.js",
                    "~/tpl/plugins/core/fastclick/fastclick.js",
                    "~/tpl/plugins/core/velocity/jquery.velocity.min.js",
                    "~/tpl/plugins/core/quicksearch/jquery.quicksearch.js",
                    "~/tpl/plugins/ui/bootbox/bootbox.mim.js",
                    "~/Scripts/jquery.unobtrusive*"
                ));

            bundles.Add(new ScriptBundle("~/bundles/otherdashboard").Include(
                    "~/tpl/js/libs/date.js",
                    "~/tpl/plugins/charts/sparklines/jquery.sparkline.js",
                    "~/tpl/plugins/charts/progressbars/progressbar.min.js",
                    "~/tpl/plugins/ui/waypoint/waypoints.js",
                    "~/tpl/plugins/ui/weather/skyicons.js",
                    "~/tpl/plugins/ui/notify/jquery.gritter.min.js",
                    "~/tpl/plugins/misc/countTo/jquery.countTo.js",
                    "~/tpl/js/jquery.dynamic.js",
                    "~/tpl/js/pages/dashboard.js",
                    "~/tpl/js/main.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/datatableswithtools").Include(
                    "~/tpl/plugins/charts/sparklines/jquery.sparkline.js",
                    "~/tpl/plugins/tables/datatables/jquery.dataTables.js",
                    "~/tpl/plugins/tables/datatables/dataTables.tableTools.js",
                    "~/tpl/plugins/tables/datatables/dataTables.bootstrap.js",
                    "~/tpl/plugins/tables/datatables/dataTables.responsive.js",
                    "~/tpl/js/jquery.dynamic.js"
                ));



            //< !--Other plugins(load only nessesary plugins for every page) -->
            bundles.Add(new ScriptBundle("~/bundles/formonlypage").Include(
                "~/tpl/plugins/forms/fancyselect/fancySelect.js",
                "~/tpl/plugins/charts/sparklines/jquery.sparkline.js",


                "~/Scripts/select2.js",
                "~/Scripts/select2_locale_pt-BR.js",
                "~/Scripts/bootstrap-tagsinput.js",
                "~/tpl/js/libs/typeahead.bundle.js",
                "~/tpl/plugins/forms/bootstrap-markdown/bootstrap-markdown.js",
                "~/tpl/plugins/forms/summernote/summernote.js",
                "~/tpl/js/pages/forms-advanced.js"
                ));


            //< !--/ Form basic-- >
            bundles.Add(new ScriptBundle("~/bundles/formbasic").Include(
              "~/tpl/plugins/forms/bootstrap-filestyle/bootstrap-filestyle.js",
              "~/tpl/plugins/forms/autosize/jquery.autosize.js",
              "~/tpl/plugins/forms/maxlength/bootstrap-maxlength.js",
              "~/tpl/plugins/forms/checkall/jquery.checkAll.js",
              "~/tpl/js/pages/forms-basic.js"
              ));

            //< !--/ Form validate-- >
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/tpl/plugins/forms/validation/additional-methods.min.js",
                "~/tpl/js/pages/forms-validation.js",
                "~/tpl/plugins/forms/validation/jquery.validate.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/formwizard").Include(
                "~/tpl/plugins/forms/bootstrap-wizard/jquery.bootstrap.wizard.js",
                "~/tpl/js/pages/forms-wizard.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/formtabs").Include(
                "~/tpl/plugins/ui/tabdrop/bootstrap-tabdrop.js",
                "~/tpl/js/jquery.dynamic.js",
                "~/tpl/js/main.js",
                "~/tpl/js/pages/tabs.js"
                ));

        }
    }
}
