import React from 'react';
import './App.css';
import { HashRouter, Navigate, Route, Routes } from 'react-router-dom';
import TypeBreadPage from './pages/typeBread/TypeBreadPage';
import HomePage from './pages/home/HomePage';
import LoginPage from './pages/login/LoginPage';
import AuthenticateLayout from './pages/AuthenticateLayout';
import MainLayout from './pages/MainLayout';
import { ConfigProvider, theme } from 'antd';
import faIR from 'antd/locale/fa_IR';
import { RequireLogin } from 'components/RequireLogin';
const { defaultAlgorithm, darkAlgorithm } = theme;

function App() {
  const [isDarkMode, setIsDarkMode] = React.useState(false);

  const setThemeLayout = (isDark: boolean): void => {
    setIsDarkMode(isDark);
  };

  return (
    <ConfigProvider
      locale={faIR}
      direction="rtl"
      componentSize="middle"
      theme={{
        algorithm: isDarkMode ? darkAlgorithm : defaultAlgorithm,
        token: {
          colorPrimary: '#F77E21',
          fontFamily: 'Vazirmatn',
        },
      }}
    >
      <HashRouter>
        <Routes>
          <Route path="authentication" element={<AuthenticateLayout />}>
            <Route path="login" element={<LoginPage />} />
          </Route>
          <Route
            path="*"
            element={
              <RequireLogin>
                <MainLayout isDarkMode={isDarkMode} setThemeLayout={setThemeLayout} />
              </RequireLogin>
            }
          >
            <Route path="home" element={<HomePage />} />
            <Route path="typebread" element={<TypeBreadPage />} />
            <Route path="*" element={<Navigate to="/home" replace />} />
          </Route>
        </Routes>
      </HashRouter>
    </ConfigProvider>
  );
}

export default App;
