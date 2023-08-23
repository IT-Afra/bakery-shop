import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { HashRouter } from 'react-router-dom';
import { ConfigProvider, theme } from 'antd';
import faIR from 'antd/locale/fa_IR';
const { defaultAlgorithm, darkAlgorithm } = theme;

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
root.render(
  <React.StrictMode>
    <ConfigProvider
      locale={faIR}
      direction="rtl"
      componentSize="middle"
      theme={{
        //algorithm: isDarkMode ? darkAlgorithm : defaultAlgorithm,
        token: {
          colorPrimary: '#F77E21',
          fontFamily: 'Vazirmatn',
        },
      }}
    >
      <HashRouter>
        <App />
      </HashRouter>
    </ConfigProvider>
  </React.StrictMode>
);

reportWebVitals();
