"use strict"
{
    // Требуется для формирования полного output пути
    let path = require('path');

    // Плагин для очистки выходной папки (bundle) перед созданием новой
    const CleanWebpackPlugin = require('clean-webpack-plugin');

    // Путь к выходной папке
    const bundleFolder = "wwwroot/bundle/";

    const ExtractTextPlugin = require("extract-text-webpack-plugin");

    module.exports = {
        // Точка входа в приложение
        entry: [
            "./Scripts/main.ts",
            './src/scss/style.scss'
        ],

        // Выходной файл
        output: {
            filename: 'script.js',
            path: path.resolve(__dirname, bundleFolder)
        },
        module: {
            rules: [
                {
                    test: /\.(sass|scss)$/,
                    include: path.resolve(__dirname, 'src/scss'),
                    use: ExtractTextPlugin.extract({
                        use: [{
                            loader: "css-loader",
                            options: {
                                sourceMap: true,
                                minimize: true,
                                url: false
                            }
                        },
                        {
                            loader: "sass-loader",
                            options: {
                                sourceMap: true
                            }
                        }
                        ]
                    }),
                    loader: "ts-loader",
                    exclude: /node_modules/
                }
            ]
        },
        resolve: {
            extensions: [".tsx", ".ts", ".js"]
        },
        plugins: [
            new ExtractTextPlugin({
                filename: './css/style.bundle.css',
                allChunks: true
            }),
            new CleanWebpackPlugin([bundleFolder])
        ],
        // Включаем генерацию отладочной информации внутри выходного файла
        // (Нужно для работы отладки клиентских скриптов)
        devtool: "inline-source-map"

    };
}