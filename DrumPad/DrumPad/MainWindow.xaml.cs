using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Media;
using WinRT;
// Needed for WindowId
using Microsoft.UI;
// Needed for AppWindow
using Microsoft.UI.Windowing;
// Needed for XAML hwnd interop
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DrumPad
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        AppWindow m_appWindow;

        public MainWindow()
        {
            this.InitializeComponent();
            m_appWindow = GetAppWindowForCurrentWindow();
        }

        private void pad_clicked(object sender, RoutedEventArgs e)
        {
            // get the full path to your app’s folder where it is installed
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            // join path above with the sub-paths in your Assets folder and the specific sound file
            var soundFile = Path.Join(installedPath, "Assets", "rim.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }


        private void pad2_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "crash.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad3_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "elec1.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad4_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "high_snare.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad5_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "high_snare2.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad6_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "kick.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad7_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "snare.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad8_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "tom.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad9_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "trash.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad10_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "clip1.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }
        private void pad11_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "clip2.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }
        private void pad12_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "clip3.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }
        private void pad13_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "clip4.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }
        private void pad14_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "clip5.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }
        private void pad15_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "clip6.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }
        private void pad16_clicked(object sender, RoutedEventArgs e)
        {
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "clip7.wav");
            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    if (this.Content is FrameworkElement frameworkElement)
                    {
                        frameworkElement.RequestedTheme = ElementTheme.Dark;
                    }
                }
                else
                {
                    if (this.Content is FrameworkElement frameworkElement)
                    {
                        frameworkElement.RequestedTheme = ElementTheme.Light;
                    }
                }
            }
        }

        private AppWindow GetAppWindowForCurrentWindow()
        {
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(myWndId);
        }

        private void SwtichPresenter_CompOverlay(object sender, RoutedEventArgs e)
        {
            m_appWindow.SetPresenter(AppWindowPresenterKind.CompactOverlay);
        }

        private void SwtichPresenter_OverLapped(object sender, RoutedEventArgs e)
        {
            m_appWindow.SetPresenter(AppWindowPresenterKind.Overlapped);
        }

        private void SwtichPresenter_Fullscreen(object sender, RoutedEventArgs e)
        {
            m_appWindow.SetPresenter(AppWindowPresenterKind.FullScreen);
        }
    }
}
