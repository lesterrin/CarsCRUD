const path = require('path');

const bundleOutputDir = './wwwroot/bundle';

module.exports = {
    entry: {
        'bootstrap': './Scripts/main.ts'
    },
    output: {
        path: path.join(__dirname, bundleOutputDir)
    },
    resolve: {
        extensions: [".tsx", ".ts", ".js"]
    },

    module: {
        rules: [
            {
                test: /\.(scss)$/,
                use: [
                    {
                        loader: 'style-loader'
                    },
                    {
                        loader: 'css-loader'
                    },
                    {
                        loader: 'postcss-loader',
                        options: {
                            plugins: function () {
                                return [
                                    require('autoprefixer')
                                ];
                            }
                        }
                    },
                    {
                        loader: 'sass-loader'
                    }
                ]
            },
            {
                test: /\.tsx?$/,
                loader: "awesome-typescript-loader",
                exclude: /node_modules/
            }
        ]
    }
};
