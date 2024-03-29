import React from 'react';
import {
  Spin,
  Row,
  Col,
  Table,
  Grid,
  Button,
  Radio,
  Form,
  Modal,
  Input,
  Popconfirm,
} from 'antd';
import { ITypeBread } from '../../models/ITypeBread';
import type { ColumnsType } from 'antd/es/table';
import { EditFilled, DeleteFilled, UserAddOutlined } from '@ant-design/icons';
import axios from 'axios';
import { AuthContext } from 'contexts/AuthContext';
import { ITypeBreadTable } from '../../models/ITypeBreadTable';

const { useBreakpoint } = Grid;

type Props = {};

const TypeBreadPage = (props: Props) => {
  const [frm] = Form.useForm<ITypeBread>();
  const [modalOpen, setModalOpen] = React.useState(false);
  const [typeBreadchange, setTypeBreadchange] = React.useState(false);
  const [isSpinning, setIsSpinning] = React.useState(true);
  const [typeBreads, setTypeBreads] = React.useState<ITypeBread[]>([]);
  const [typeBreadTable, setTypeBreadTable] = React.useState<ITypeBreadTable[]>([]);
  const screens = useBreakpoint();
  const [selectedRowKeys, setSelectedRowKeys] = React.useState<React.Key[]>([]);
  const [selectedRowID, setSelectedRowID] = React.useState<React.Key[]>([0]);
  const authContext = React.useContext(AuthContext);

  const getTypeBreads = () => {
    axios
      .get<ITypeBread[]>('/api/typeBread', {
        headers: { Authorization: `Bearer ${localStorage.getItem('access-token')}` },
      })
      .then(function (response) {
        setTypeBreadTable(
          response.data.map((x) => {
            return { key: x.id, ...x };
          })
        );
      })
      .catch(function (error) {
        // handle error
        console.log(error);
      })
      .finally(function () {
        setIsSpinning(false);
      });
  };

  React.useEffect(() => {
    getTypeBreads();
  }, [typeBreadchange]);

  const onSave = () => {
    setIsSpinning(true);
    frm.submit();
    frm
      .validateFields()
      .then(save)
      .catch()
      .finally(() => {
        setModalOpen(false);
        setTypeBreadchange(false);
      });
  };

  const save = (typeBread: ITypeBread) => {
    axios
      .post<ITypeBread>('https://localhost:7239/api/typeBread', {
        id: typeBread.id,
        name: typeBread.name,
        photoGuid: typeBread.photoGuid,
        isActive: typeBread.isActive,
      }, {
        headers: {
          'Authorization': `bearer ${localStorage.getItem('access-token')}`
        }
      })
      .then((response) => {
        setIsSpinning(true);
        let data: ITypeBread[] = [response.data, ...typeBreads];
        setTypeBreads(data);
      })
      .catch((error) => {
        // handle error
        console.log(error);
      })
      .finally(() => {
        setIsSpinning(false);
        setTypeBreadchange(true);
      });
  };

  const onEdit = (id: React.Key) => {
    console.log(id);
    const typeBread = typeBreadTable.find((p) => p.id === id);
    if (typeBread) {
      frm.setFieldsValue(typeBread);
      setModalOpen(true);
    }
  };

  const Delete = () => {
    selectedRowID.map((x) => {
      console.log(x);
      axios
        .delete(`https://localhost:7239/api/typeBread/${x}`)
        .then((response) => {
          setIsSpinning(true);
          setTypeBreadchange(true);
        })
        .catch((error) => {
          console.error(error);
        })
        .finally(() => {
          setIsSpinning(false);
          setTypeBreadchange(true);
        });
    });
  };

  const onSelectChange = (newSelectedRowKeys: React.Key[], selectedRow: ITypeBread[]) => {
    let ids = selectedRow.map((x) => {
      return x.id;
    });
    setSelectedRowID(ids);
    setSelectedRowKeys(newSelectedRowKeys);
  };
  const rowSelection = {
    selectedRowKeys,
    onChange: onSelectChange,
  };

  const newUser = () => {
    frm.resetFields();
    setModalOpen(true);
  };

  const columnsMobile: ColumnsType<ITypeBread> = [
    {
      title: 'لیست نان های موجود',
      dataIndex: 'Bread',
      render: (text: string, record: ITypeBread) => (
        <div>
          <span style={{ display: 'flex' }}>
            <div style={{ width: '25%' }}>ردیف : </div>
            <div style={{ width: '75%', fontWeight: 'bold' }}>{record.id}</div>
          </span>
          <span style={{ display: 'flex' }}>
            <div style={{ width: '25%' }}>نام : </div>
            <div style={{ width: '75%', fontWeight: 'bold' }}>{record.name}</div>
          </span>
          <span style={{ display: 'flex' }}>
            <div style={{ width: '25%' }}>وضعیت : </div>
            <div style={{ width: '75%', fontWeight: 'bold' }}>{record.isActive}</div>
          </span>
          <span style={{ display: 'flex' }}>
            <div style={{ width: '25%' }}>عکس : </div>
            <div style={{ width: '75%', fontWeight: 'bold' }}>{record.photoGuid}</div>
          </span>
          <span style={{ display: 'flex' }}>
            <div style={{ width: '25%' }}>ویرایش : </div>
            <Button
              icon={<EditFilled />}
              style={{ color: 'red' }}
              onClick={() => setModalOpen(true)}
            ></Button>
            <div style={{ width: '75%', fontWeight: 'bold' }}></div>
          </span>
        </div>
      ),
    },
  ];

  const columns: ColumnsType<ITypeBread> = [
    {
      title: 'ردیف',
      dataIndex: 'id',
    },
    {
      title: 'عنوان',
      dataIndex: 'name',
    },
    {
      title: 'وضعیت',
      dataIndex: 'isActive',
      render: (isActive: boolean) => (isActive ? 'فعال' : 'غیرفعال'),
    },
    {
      title: 'عکس',
      dataIndex: 'photoGuid',
    },
    {
      title: 'ویرایش',
      dataIndex: 'id',
      render: (id: React.Key) => (
        <Button
          icon={<EditFilled />}
          style={{ backgroundColor: '#FFB200' }}
          onClick={() => onEdit(id)}
        ></Button>
      ),
    },
  ];

  return (
    <Spin spinning={isSpinning}>
      <Row>
        <Col span={5}>
          <h1 style={{ fontWeight: 'bold', display: 'flex' }}>انواع نان </h1>
        </Col>
      </Row>
      <Button
        style={{ float: 'left', width: '60px', background: 'rgb(255, 178, 0)', display: 'inline' }}
        icon={<UserAddOutlined />}
        onClick={() => newUser()}
      />
      <Table
        rowSelection={rowSelection}
        columns={screens.xs ? columnsMobile : columns}
        dataSource={typeBreadTable}
        pagination={{ pageSize: 3 }}
      />
      <Popconfirm
        title="حذف سطر"
        description="آیا اطمینان به حذف موارد فوق دارید؟"
        onConfirm={() => Delete()}
        okText="بله"
        cancelText="خیر"
      >
        <Button
          icon={<DeleteFilled />}
          style={{ background: '#c71e1e', width: '60px', color: 'white' }}
        />
      </Popconfirm>
      <Modal
        title="ویرایش اطلاعات نان"
        open={modalOpen}
        onCancel={() => setModalOpen(false)}
        onOk={() => onSave()}
      >
        <Form form={frm}>
          <Form.Item name="id" label="شناسه" hidden></Form.Item>
          <Form.Item
            name="name"
            label="نام"
            rules={[{ required: true }, { type: 'string', max: 100 }]}
            labelCol={{ span: 5 }}
            wrapperCol={{ span: 19 }}
          >
            <Input placeholder="لطفا نام نان را وارد فرمایید  :" />
          </Form.Item>
          <Form.Item
            name="photoGuid"
            label="عکس "
            rules={[{ required: true }, { type: 'string', max: 50 }]}
            labelCol={{ span: 5 }}
            wrapperCol={{ span: 19 }}
          >
            <Input placeholder="لطفا عکس نان را وارد فرمایید  :" />
          </Form.Item>
          <Row>
            <Col span={12}>
              <Form.Item
                name="isActive"
                label="وضعیت"
                rules={[{ required: true }]}
                labelCol={{ span: 11 }}
                wrapperCol={{ span: 13 }}
              >
                <Radio.Group>
                  <Radio value={true}>موجود</Radio>
                  <Radio value={false}>ناموجود</Radio>
                </Radio.Group>
              </Form.Item>
            </Col>
          </Row>
        </Form>
      </Modal>
    </Spin>
  );
};

export default TypeBreadPage;
