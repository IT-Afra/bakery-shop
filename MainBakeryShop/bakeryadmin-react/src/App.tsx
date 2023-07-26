import React from 'react';
import './App.css';
import { HashRouter, Navigate, Route, Routes } from "react-router-dom";
import TypeBreadPage from './pages/typeBread/TypeBreadPage';
import HomePage from './pages/home/HomePage';
import LoginPage from './pages/login/LoginPage';
import AuthenticateLayout from './pages/AuthenticateLayout';
import MainLayout from './pages/MainLayout';

function App() {
  return (
    <HashRouter>
       <Routes>

        <Route path="login" element={<AuthenticateLayout />} >
          <Route path="*" element={<LoginPage />} />
        </Route>

        <Route path="*" element={<MainLayout />} >
          <Route path="home" element={<HomePage />} /> 
          <Route path="typebread" element={<TypeBreadPage />} /> 
          <Route path='*' element={<Navigate to="/home" replace />} />
        </Route>

      </Routes>
    </HashRouter>
  );
}

export default App;
