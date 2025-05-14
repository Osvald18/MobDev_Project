using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using Microsoft.Maui.Graphics;

namespace Proj;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // Modify the EntryHandler to make the underline transparent on Android
        EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#endif
#if IOS
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
        });
        
        EditorHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
#if ANDROID
            if (handler.PlatformView is Android.Widget.EditText nativeEditor)
            {
                // Remove underline
                nativeEditor.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.White);

                // Set custom background drawable with solid color and rounded corners
                var drawable = new Android.Graphics.Drawables.GradientDrawable();
                drawable.SetColor(Android.Graphics.Color.ParseColor("#F5F5F5")); // Your desired background color
                drawable.SetCornerRadius(30f); // Rounded corners
                nativeEditor.Background = drawable;

                // Optional: Set padding
                nativeEditor.SetPadding(40, 40, 40, 40);
            }
#endif
        });
        
        builder .ConfigureFonts(fonts =>
        {
            fonts.AddFont("CircularStd-Bold.otf", "Circular");
        });
        
        builder .ConfigureFonts(fonts =>
        {
            fonts.AddFont("CircularStd-Black.otf", "Circular_Norm");
        });

        
        return builder.Build();
    }
}



