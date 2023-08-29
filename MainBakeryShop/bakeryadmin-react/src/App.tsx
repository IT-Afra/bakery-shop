import React from 'react';
import './App.css';
import { useNavigate, Navigate, Route, Routes } from 'react-router-dom';
import TypeBreadPage from './pages/typeBread/TypeBreadPage';
import HomePage from './pages/home/HomePage';
import LoginPage from './pages/login/LoginPage';
import AuthenticateLayout from './pages/AuthenticateLayout';
import MainLayout from './pages/MainLayout';
import { ConfigProvider, theme } from 'antd';
import faIR from 'antd/locale/fa_IR';
import { IUserToken } from 'models/IUserToken';
import { AuthContext, RequireLogin } from 'contexts/AuthContext';
const { defaultAlgorithm, darkAlgorithm } = theme;

function App() {
  const [isDarkMode, setIsDarkMode] = React.useState(false);
  const navigate = useNavigate();
  const [userToken, setUserToken] = React.useState<IUserToken>();

  const login = (userToken: IUserToken) => {
    setUserToken(userToken);
    navigate('/');
  };

  const logout = () => {
    setUserToken(undefined);
    localStorage.clear();
    window.location.reload();
    navigate('/');
  };
  const isInRole = (roleName: string) => {
    if (userToken && userToken.role === roleName) return true;
    return false;
  };

  const setThemeLayout = (isDark: boolean): void => {
    setIsDarkMode(isDark);
  };

  return (
    <AuthContext.Provider
      value={{ userToken: userToken, login: login, logout: logout, isInRole: isInRole }}
    >
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
    </AuthContext.Provider>
  );
}

export default App;
